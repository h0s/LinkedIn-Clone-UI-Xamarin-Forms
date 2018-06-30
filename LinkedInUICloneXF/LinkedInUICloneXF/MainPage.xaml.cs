using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedInUICloneXF.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LinkedInUICloneXF
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
	{
	    private List<PostItem> ListPosts=new List<PostItem>();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(Navigation);
            ListOfPost.ItemsSource = ListPosts=new List<PostItem>()
            {
                new PostItem()
                {
                    PersonName = "John Doe",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PersonCurrentPosition = "Manager at Company",
                    PersonProfilePicture = "person1",
                    Date = "10h",
                    PostComments = 3,
                    PostLikes = 10
                },
                new PostItem()
                {
                    PersonName = "Jane Doe",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    PersonCurrentPosition = "CEO at Company",
                    PersonProfilePicture = "person2",
                    Date = "2d",
                    PostComments = 1,
                    PostLikes = 9

                },
                new PostItem()
                {
                    PersonName = "Marc Zuck",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PersonCurrentPosition = "Manager at Company",
                    PersonProfilePicture = "person1",
                    Date = "10h",
                    PostComments = 3,
                    PostLikes = 10
                },
                new PostItem()
                {
                    PersonName = "Daniel Joe",
                    Description =
                        "Lorem  dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    PersonCurrentPosition = "CEO at Company",
                    PersonProfilePicture = "person2",
                    Date = "2d",
                    PostComments = 1,
                    PostLikes = 9

                },
                new PostItem()
                {
                    PersonName = "John Doe",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PersonCurrentPosition = "Manager at Company",
                    PersonProfilePicture = "person1",
                    Date = "10h",
                    PostComments = 3,
                    PostLikes = 10
                },
                new PostItem()
                {
                    PersonName = "Jane Doe",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    PersonCurrentPosition = "CEO at Company",
                    PersonProfilePicture = "person2",
                    Date = "2d",
                    PostComments = 1,
                    PostLikes = 9

                },
                new PostItem()
                {
                    PersonName = "Marc Zuck",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PersonCurrentPosition = "Manager at Company",
                    PersonProfilePicture = "person1",
                    Date = "10h",
                    PostComments = 3,
                    PostLikes = 10
                },
                new PostItem()
                {
                    PersonName = "Daniel Joe",
                    Description =
                        "Lorem  dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    PersonCurrentPosition = "CEO at Company",
                    PersonProfilePicture = "person2",
                    Date = "2d",
                    PostComments = 1,
                    PostLikes = 9

                }
            };
            ListOfPost.HeightRequest = ListOfPost.RowHeight * ListPosts.Count;

        }

        private double oldY = 0;
        private void MyScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            if (e.ScrollY > oldY)
            {
                HideBars();
                Debug.WriteLine("DOWNNNNNNNN");

            }
            else if(e.ScrollY<oldY)
            {
                ShowBars();
                Debug.WriteLine("UPPPP");

            }

            oldY = e.ScrollY;

            //Debug.WriteLine("------X="+e.ScrollX+"-Y="+e.ScrollY);

        }

	    private void ShowBars()
	    {
	        BottomBar.TranslateTo(0, 0, 250u);
	        TopBar.TranslateTo(0, 0, 250u);
        }

        private void HideBars()
	    {
	        BottomBar.TranslateTo(0, 100, 250u);
	        TopBar.TranslateTo(0, -100, 250u);

        }

        private void ListOfPost_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        ((ListView) sender).SelectedItem = null;
	    }
	}

    public class MainPageViewModel : BindableObject
    {
        private readonly INavigation navigation;
     

      

     
        public MainPageViewModel(INavigation navigation)
        {
            this.navigation = navigation;
        }

        public Command OpenVapoliaCommand => new Command(async () =>
        {
        });

        public Command<Point> PanCommand => new Command<Point>(point =>
        {
           
          
        });
    }
}