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
using BethanysPieShop.Utitlities;
using BethanysPieShopCore;
using BethanysPieShopCore.Models;

namespace BethanysPieShop
{
    [Activity(Label = "PieDetailActivity" )]
    public class PieDetailActivity : Activity
    {
        private IPieRepository _pieRepository;
        private Pie _selectedPie;
        private ImageView _pieImageView;
        private TextView _pieNameTextView;
        private TextView _shortDescriptionTextView;
        private TextView _descriptionTextView;
        private TextView _priceTextView;
        private EditText _amountEditText;
        private Button _addToCartButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pie_detail);

            _pieRepository = new PieRepository();
            _selectedPie = _pieRepository.Get(Intent.Extras.GetInt("selectedPieId"));
            InitializeViews();
            BindDataToViews();
        }
        private void BindDataToViews()
        {
            _pieNameTextView.Text = _selectedPie.Name;
            _shortDescriptionTextView.Text = _selectedPie.ShortDescription;
            _descriptionTextView.Text = _selectedPie.Description;
            _priceTextView.Text = "Price: $"+_selectedPie.Price.ToString();
            _pieImageView.SetImageBitmap(ImageService.GetBitmapFromUrl(_selectedPie.ImageUrl));
        }
        private void InitializeViews()
        {
            _pieImageView = FindViewById<ImageView>(Resource.Id.pieImageView);
            _pieNameTextView = FindViewById<TextView>(Resource.Id.pieNameTextView);
            _shortDescriptionTextView = FindViewById<TextView>(Resource.Id.shortDescriptionTextView);
            _descriptionTextView = FindViewById<TextView>(Resource.Id.descriptionTextView);
            _priceTextView = FindViewById<TextView>(Resource.Id.priceTextView);
            _amountEditText = FindViewById<EditText>(Resource.Id.amountEditText);
            _addToCartButton = FindViewById<Button>(Resource.Id.addToCartButton);

            _addToCartButton.Click += (sender, args) =>
             {
                 ShoppingCart.Add(_selectedPie, Convert.ToInt32(_amountEditText.Text));
                 Toast.MakeText(Application.Context, "Pie added to cart", ToastLength.Long).Show();
                 this.Finish();
             };
        }
    }
}