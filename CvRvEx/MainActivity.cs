using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using System;

namespace CvRvEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private RecyclerView _myRecycleView;
        private PhotoAdapter _myPhotoAdapter;
        RecyclerView.LayoutManager _mylayoutmanger;
     
        PhotoAlbum _myPhotoAlbum;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            _myPhotoAlbum = new PhotoAlbum();
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            
            _myRecycleView = FindViewById<RecyclerView>(Resource.Id._albumRecyclerView);

            _mylayoutmanger = new GridLayoutManager(this,2,GridLayoutManager.Vertical,false);
            _myRecycleView.SetLayoutManager(_mylayoutmanger);

            _myPhotoAdapter = new PhotoAdapter(_myPhotoAlbum);
            _myRecycleView.SetAdapter(_myPhotoAdapter);
            _myPhotoAdapter.ItemClick += OnItemclicked;
        }

        void OnItemclicked(object sender, int position)
        {
            int photopos = position + 1;
            Toast.MakeText(this, "This is photo number " + photopos, ToastLength.Short).Show();
        }
        
            
        
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}