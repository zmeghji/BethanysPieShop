using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using BethanysPieShop.Fragments;
using BethanysPieShopCore;
using BethanysPieShopCore.Models;
using BethanysPieShopCore.Repositories;
using Java.Lang;

namespace BethanysPieShop.Adapters
{
    public class CategoryFragmentAdapter : FragmentPagerAdapter
    {
        private readonly List<Category> categories;
        public CategoryFragmentAdapter(Android.Support.V4.App.FragmentManager fragmentManager) : base(fragmentManager)
        {
            categories = new CategoryRepository().Get();
        }
        public override int Count => categories.Count;
        
        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return new PieCategoryFragment(categories[position]);
        }
        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(categories[position].Name);
            //return base.GetPageTitleFormatted(position);
        }
    }
}