using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MovieSearch.Domain.Repositories;

namespace MovieSearch.Droid
{
    [Activity(Label = "MovieSearch.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var getMovie = FindViewById<Button>(Resource.Id.getMovie);
            var movie = FindViewById<EditText>(Resource.Id.movie);
            var title = FindViewById<TextView>(Resource.Id.title);
            var releaseDate = FindViewById<TextView>(Resource.Id.release_date);
            var overview = FindViewById<TextView>(Resource.Id.overview);

            getMovie.Click += async (IntentSender, e) =>
            {
                var repository = new MovieRepository(movie.Text);
                var moview = await repository.GetMovie();

                title.Text = $"";
            };
        }
    }
}

