using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1.DTO;

namespace App1.Adapteur
{
   class UsagerAdapteur : BaseAdapter<UsagerDTO>
   {
         private Activity context;
         private List<UsagerDTO> usager;

         public UsagerAdapteur(Activity context, List<UsagerDTO> usager)
         {
            this.context = context;
            this.usager = usager;
         }

         public override UsagerDTO this[int index]
         {
            get { return this.usager[index]; }
         }

         public override long GetItemId(int position)
         {
            return position;
         }

         public override int Count
         {
            get { return this.usager.Count; }
         }

         public override View GetView(int position, View convertView, ViewGroup parent)
         {
            UsagerDTO item = this.usager[position];

            View view =
               (convertView ??
                  context.LayoutInflater.Inflate(
                     Resource.Layout.ListViewUsagerItem,
                     parent,
                     false)) as LinearLayout;

            TextView ContenuUsager = view.FindViewById<TextView>(Resource.Id.ContenuUsager);
            ContenuUsager.SetText(item.NomUsager, TextView.BufferType.Normal);

         

            return view;
         }
      }
}