using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignaturePad.Forms;
using Xamarin.Forms;

namespace SignaturePadXfDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Clear_Button_OnClicked(object sender, EventArgs e)
        {
            FooSignaturePad.Clear();
        }

        private async void Submit_Button_OnClicked(object sender, EventArgs e)
        {
            var signedImageStream = await FooSignaturePad.GetImageStreamAsync(SignatureImageFormat.Jpeg);
            //TODO: Your logic here
            await DisplayAlert("Acme Company", "Your signed agreement has been sent", "OK");
        }
    }
}
