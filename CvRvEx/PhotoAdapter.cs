using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CvRvEx
{
    class PhotoAdapter : RecyclerView.Adapter
    {
        PhotoAlbum _myPhotoAlbum;
        public event EventHandler<int> ItemClick;

        public PhotoAdapter(PhotoAlbum myPhotoAlbum)
        {
            _myPhotoAlbum = myPhotoAlbum;
        }

        public override int ItemCount
        {
            get { return _myPhotoAlbum.NumbPhotos; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            PhotoViewHolder photoViewHolder = holder as PhotoViewHolder;
            photoViewHolder.Binddata(_myPhotoAlbum, position);
            // photoViewHolder._myImageView.SetImageResource(_myPhotoAlbum[position].PhotoId);
            // photoViewHolder._myTextView.Text = _myPhotoAlbum[position].Caption;



        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CardView, parent, false);
            return new PhotoViewHolder(view, OnClick);

        }

         private void OnClick(int position)
         {
             if (ItemClick != null)
             {
                 ItemClick?.Invoke(this, position);
             }
             ItemClick?.Invoke(this, position);
         }
     }

        class PhotoViewHolder : RecyclerView.ViewHolder
        {

            public ImageView _myImageView;
            public TextView _myTextView;
            public PhotoViewHolder(View itemView, Action<int> listner) : base(itemView)
            {
                _myImageView = itemView.FindViewById<ImageView>(Resource.Id.imageView);
                _myTextView = itemView.FindViewById<TextView>(Resource.Id.textView);

                itemView.Click += (sender, e) => listner.Invoke(base.LayoutPosition);
            }

            internal void Binddata(PhotoAlbum myPhotoAlbum, int position)
            {
                _myImageView.SetImageResource(myPhotoAlbum[position].PhotoId);
                _myTextView.Text = myPhotoAlbum[position].Caption;

            }
        }
}