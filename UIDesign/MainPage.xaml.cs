using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System.Collections.Generic;

namespace UIDesign
{
    public partial class MainPage : ContentPage
    {
        // List of image URLs for posts
        private List<string> imageUrls = new List<string>
        {
            "https://via.placeholder.com/350x250", // Placeholder image 1
            "https://via.placeholder.com/350x250/ff0000", // Placeholder image 2
            "https://via.placeholder.com/350x250/00ff00", // Placeholder image 3
            "https://via.placeholder.com/350x250/0000ff", // Placeholder image 4
            "https://via.placeholder.com/350x250/ffff00"  // Placeholder image 5
        };

        public MainPage()
        {
            InitializeComponent();
            CreatePosts();
        }

        private void CreatePosts()
        {
            for (int i = 0; i < 5; i++)
            {
                var userName = $"User{i + 1}"; // Hardcoded username, you can replace this with dynamic input
                var description = $"Description for post {i + 1}"; // Hardcoded description, you can replace this as well

                var postCard = CreatePostCard(userName, description, imageUrls[i]);
                feedLayout.Children.Add(postCard);
            }
        }

        private Grid CreatePostCard(string username, string description, string imageUrl)
        {
            var postCard = new Grid
            {
                Margin = new Thickness(10),
                Padding = new Thickness(10),
                BackgroundColor = Colors.White
            };

            var postLayout = new VerticalStackLayout();

            var userLabel = new Label
            {
                Text = username,
                FontAttributes = FontAttributes.Bold
            };

            var descriptionLabel = new Label
            {
                Text = description
            };

            var postImage = new Image
            {
                HeightRequest = 250,
                WidthRequest = 350,
                Source = imageUrl, // Dynamically assigning image source
                BackgroundColor = Colors.LightGray,
                Aspect = Aspect.AspectFill
            };

            postLayout.Children.Add(userLabel);
            postLayout.Children.Add(postImage);
            postLayout.Children.Add(descriptionLabel);

            postCard.Children.Add(postLayout);

            return postCard;
        }
    }
}
