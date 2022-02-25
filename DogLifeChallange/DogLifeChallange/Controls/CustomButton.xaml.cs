using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DogLifeChallange.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomButton : Frame
    {

        public static readonly BindableProperty HasIconProperty =
            BindableProperty.Create(
                nameof(HasIcon),
                typeof(bool),
                typeof(CustomButton),
                defaultValue: false);

        public bool HasIcon
        {
            get { return (bool)GetValue(HasIconProperty); }
            set { SetValue(HasIconProperty, value); }
        }

        public static readonly BindableProperty SourceImageProperty =
            BindableProperty.Create(
                nameof(SourceImage),
                typeof(ImageSource),
                typeof(CustomButton),
                defaultValue: null,
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnSourceImagePropertyChanged);

        private static void OnSourceImagePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is CustomButton button && newValue is ImageSource image)
                button.sourceImage.Source = image;
        }

        public ImageSource SourceImage
        {
            get { return (ImageSource)GetValue(SourceImageProperty); }
            set { SetValue(SourceImageProperty, value); }
        }

        public CustomButton()
        {
            InitializeComponent();
        }
    }
}