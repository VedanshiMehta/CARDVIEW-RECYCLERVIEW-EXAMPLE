using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CvRvEx
{
    public class Photo
    {
        public Photo(int id, string caption)
        {
            PhotoId = id;
            Caption = caption;
        }

        public int PhotoId { get; }
        public string Caption { get; }
    }
    class PhotoAlbum
    {
        static Photo[] photoCollection = {

            new Photo(Resource.Drawable.TurkeyAnkara, "Ankara"),
            new Photo(Resource.Drawable.TurkeyAntalya, "Antalya"),
            new Photo(Resource.Drawable.TurkeyCappadocia, "Cappadocia"),
            new Photo(Resource.Drawable.TurkeyEphesus, "Ephesus"),
            new Photo(Resource.Drawable.TurkeyIstanbul, "Istanul"),
            new Photo(Resource.Drawable.TurkeyIzmir, "Izmir"),
            new Photo(Resource.Drawable.TurkeyAnkara, "Ankara"),
            new Photo(Resource.Drawable.TurkeyAntalya, "Antalya"),
            new Photo(Resource.Drawable.TurkeyCappadocia, "Cappadocia"),
            new Photo(Resource.Drawable.TurkeyEphesus, "Ephesus"),
            new Photo(Resource.Drawable.TurkeyIstanbul, "Istanul"),
            new Photo(Resource.Drawable.TurkeyIzmir, "Izmir"),
            new Photo(Resource.Drawable.TurkeyAnkara, "Ankara"),
            new Photo(Resource.Drawable.TurkeyAntalya, "Antalya"),
            new Photo(Resource.Drawable.TurkeyCappadocia, "Cappadocia"),
            new Photo(Resource.Drawable.TurkeyEphesus, "Ephesus"),
            new Photo(Resource.Drawable.TurkeyIstanbul, "Istanul"),
            new Photo(Resource.Drawable.TurkeyIzmir, "Izmir"),
            new Photo(Resource.Drawable.TurkeyAnkara, "Ankara"),
            new Photo(Resource.Drawable.TurkeyAntalya, "Antalya"),
            new Photo(Resource.Drawable.TurkeyCappadocia, "Cappadocia"),
            new Photo(Resource.Drawable.TurkeyEphesus, "Ephesus"),
            new Photo(Resource.Drawable.TurkeyIstanbul, "Istanul"),
            new Photo(Resource.Drawable.TurkeyIzmir, "Izmir"),
            new Photo(Resource.Drawable.TurkeyAnkara, "Ankara"),
            new Photo(Resource.Drawable.TurkeyAntalya, "Antalya"),
            new Photo(Resource.Drawable.TurkeyCappadocia, "Cappadocia"),
            new Photo(Resource.Drawable.TurkeyEphesus, "Ephesus"),
            new Photo(Resource.Drawable.TurkeyIstanbul, "Istanul"),
            new Photo(Resource.Drawable.TurkeyIzmir, "Izmir"),
        };

        private Photo[] mPhoto;

        Random rand;

        public PhotoAlbum()
        {
            mPhoto= photoCollection;
            rand = new Random();
        }

        public int NumbPhotos
        {
            get { return mPhoto.Length; }
        }
        public Photo this[int i]
        {
            get { return mPhoto[i]; }
        }

        public int RandomSwap()
        {
            Photo tempPhoto = mPhoto[0];

            int random = rand.Next(1,mPhoto.Length);

            mPhoto[0] = mPhoto[random];
            mPhoto[random] = tempPhoto;

            return random;
        }

        public void Suffle()
        {
            for (int i = 0; i < mPhoto.Length; i++)
            {
                Photo tempPhoto = mPhoto[i];

                int random = rand.Next(1, mPhoto.Length);

                mPhoto[i] = mPhoto[random];
                mPhoto[random] = tempPhoto;
            }

        }
    }
}