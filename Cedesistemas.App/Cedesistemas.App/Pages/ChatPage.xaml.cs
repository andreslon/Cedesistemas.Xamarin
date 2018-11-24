using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cedesistemas.App.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChatPage : ContentPage
	{
		public ChatPage ()
		{
			InitializeComponent ();
		}

        async private void EnviarBtn_Clicked(object sender, EventArgs e)
        {
            ChatNombreTxt.Text = NombreTxt.Text + " dijo:";
            ChatMensajeTxt.Text = MensajeTxt.Text;

            NombreTxt.Text = string.Empty;
            MensajeTxt.Text = string.Empty;

            await CrossTextToSpeech.Current.Speak(ChatMensajeTxt.Text);
        }
    }
}