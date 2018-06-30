using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedInUICloneXF.Model;
using Xamarin.Forms;

namespace LinkedInUICloneXF
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    Content.BindingContext = new MainPageViewModel();
            ListOfPost.ItemsSource=new List<PostItem>()
            {
                new PostItem()
                {
                    PersonName = "John Doe",
                    Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PersonCurrentPosition = "Manager at Company",
                    PersonProfilePicture = "person1",
                    Date = "10h",
                    PostComments = 3,PostLikes = 10
                },
                new PostItem()
                {
                    PersonName = "Jane Doe",
                    Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    PersonCurrentPosition = "CEO at Company",
                    PersonProfilePicture = "person2",
                    Date = "2d",
                    PostComments = 1,PostLikes = 9

                }
            };
		}

	    private void ListOfPost_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
            //this just to remove click color
	        ((ListView) sender).SelectedItem = null;
	    }
	}
}
