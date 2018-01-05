using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Input;
using CustomerPortalApp.ViewModels;
using Prism.Commands;
using Xamarin.Forms;

namespace CustomerPortalApp.Controls
{
    /// <summary>
    /// Carousel control.
    /// </summary>
    public partial class CarouselControl : ContentView
    {
        /// <summary>
        /// The dots.
        /// </summary>
        List<Button> dots = new List<Button>();

        /// <summary>
        /// The data template property.
        /// </summary>
        public static BindableProperty DataTemplateProperty =
            BindableProperty.Create(
                nameof(DataTemplate),
                    typeof(DataTemplate),
                typeof(DataTemplate),
                null,
                BindingMode.OneWay,
                propertyChanging: (bindable, oldValue, newValue) =>
                {

                },
                propertyChanged: (bindable, oldValue, newValue) =>
                {

                }
        );

        /// <summary>
        /// Gets or sets the data template.
        /// </summary>
        /// <value>The data template.</value>
        public DataTemplate DataTemplate
        {
            get
            {
                return (DataTemplate)GetValue(DataTemplateProperty);
            }
            set
            {
                this.ColorsPageCarousel.ItemTemplate = value;
                SetValue(DataTemplateProperty, value);
            }
        }

        /// <summary>
        /// Itemses the collection changed.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.BuildDots();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CustomerPortalApp.Controls.CarouselControl"/> class.
        /// </summary>
        public CarouselControl()
        {
            InitializeComponent();
            this.ColorsPageCarousel.ItemTemplate = DataTemplate;
            this.ColorsPageCarousel.ItemSelected += this.CarouselItemSelected;
            this.CarouselPanel.BindingContext = this;
        }

        ///// <summary>
        ///// The command property.
        ///// </summary>
        //public static readonly BindableProperty CommandProperty =
        //    BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(CarouselControl));

        ///// <summary>
        ///// Gets or sets the command.
        ///// </summary>
        ///// <value>The command.</value>
        //public ICommand Command
        //{
        //    get {  

        //       var result = GetValue(CommandProperty);
        //        return result as ICommand;
        //    }
        //    set 
        //    { 
        //        SetValue(CommandProperty, value); 
        //    }
        //}


        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create<CarouselControl, ICommand>(w => w.Command, default(ICommand),
                propertyChanged: (bindable, oldvalue, newvalue) => ((CarouselControl)bindable).OnCommandChanged(newvalue));


        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly BindableProperty ItemSourceProperty =
            BindableProperty.Create<CarouselControl, IEnumerable>(w => w.ItemSource, default(IEnumerable),
                propertyChanged: (bindable, oldvalue, newvalue) => ((CarouselControl)bindable).OnItemSourceChanged(newvalue, oldvalue));

        public IEnumerable ItemSource
        {
            get { return (IEnumerable)GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value); }
        }

        /// <summary>
        /// Carousels the item selected.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void CarouselItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (this.Command == null)
            {
                return;
            }

            var parameter = e.SelectedItem;

            if (this.Command.CanExecute(parameter))
            {
                this.Command.Execute(parameter);
            }
        }

        /// <summary>
        /// Ons the binding context changed.
        /// </summary>
        //protected override void OnBindingContextChanged()
        //{
        //    base.OnBindingContextChanged();

        //    var items = this.BindingContext as INotifyCollectionChanged;

        //    if (items != null)
        //    {
        //        items.CollectionChanged -= this.Items_CollectionChanged;
        //        items.CollectionChanged += this.Items_CollectionChanged;
        //    }
        //}

        private void OnItemSourceChanged(IEnumerable newvalue, IEnumerable oldValue)
        {
            var items = this.ItemSource as INotifyCollectionChanged;

            if (items != null)
            {
                items.CollectionChanged -= this.Items_CollectionChanged;
                items.CollectionChanged += this.Items_CollectionChanged;
            }
        }

        /// <summary>
        /// Selects the dot.
        /// </summary>
        /// <param name="position">Position.</param>
        void SelectDot(int position)
        {
            if (dots.Count == 0 || position >= dots.Count)
            {
                return;
            }

            foreach (Button dot in dots)
            {
                dot.Opacity = 0.5f;
            }
            dots[position].Opacity = 1.0f;
        }

        /// <summary>
        /// Builds the dots.
        /// </summary>
        public void BuildDots()
        {
            var items = this.ItemSource as IEnumerable<object>;

            if (items != null)
            {
                var dotsPanel = this.Content.FindByName<StackLayout>("DotsIndicator");
                dots.Clear();
                dotsPanel.Children.Clear();
                var itemCount = items.Count();

                for (int c = 0; c < itemCount; c++)
                {
                    var button = new Button
                    {
                        BorderRadius = Convert.ToInt32(3),
                        HeightRequest = 5,
                        WidthRequest = 5,
                        BackgroundColor = Xamarin.Forms.Color.Black,
                        Opacity = (c == 0 ? 1.0f : 0.5f)
                    };
                    dotsPanel.Children.Add(button);
                    dots.Add(button);
                }

                ColorsPageCarousel.ItemSelected += (sender, e) =>
                {
                    SelectDot(((CarouselView)sender).Position);
                };
            }
        }


        public void OnCommandChanged(ICommand command)
        {
            var boom = 2;
        }
    }
}
