using System.Windows;
using System.Windows.Controls;

namespace KEGE_Station
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GridFacade facade = new GridFacade();

        public MainWindow()
        {
            InitializeComponent();
            SetButtonsBehavior();
            SetGrids();
        }

        private void SetGrids()
        {
            GridFacade.SetLogo(Logo);
            GridFacade.SetGPB(GeneratorPanelButtons);
            GridFacade.SetCOOP(CreateOwnOptionPanel);
            GridFacade.SetGOP(GenerateOptionsPanel);
            GridFacade.SetEOP(EditOptionPanel);
            GridFacade.SetCRP(CheckResultPanel);
        }

        private void SetButtonsBehavior()
        {
            // Green behavior
            ButtonBehavior.Apply(Logo_btn);
            ButtonBehavior.Apply(OpenGenerator_btn);
            ButtonBehavior.Apply(OpenEdit_btn);
            ButtonBehavior.Apply(OpenResults_btn);
            ButtonBehavior.Apply(CreateOwnOption_btn);
            ButtonBehavior.Apply(GenerateOptions_btn);
            ButtonBehavior.Apply(CreateOwnOption_AddTask_btn);
            ButtonBehavior.Apply(CreateOwnOption_Save_btn);
            ButtonBehavior.Apply(GenerateOptionsPanel_Generate_btn);
            ButtonBehavior.Apply(EditOptionPanel_AddTask_btn);
            ButtonBehavior.Apply(EditOptionPanel_Save_btn);
            ButtonBehavior.Apply(ChoiceOption);
            ButtonBehavior.Apply(ChoiceRepository);

            // Reg behavior
            ButtonBehavior.Apply(CreateOwnOption_Back_btn, true);
            ButtonBehavior.Apply(CreateOwnOption_Erase_btn, true);
            ButtonBehavior.Apply(GenerateOptionsPanel_Back_btn, true);
            ButtonBehavior.Apply(EditOptionPanel_Erase_btn, true);
        }

        #region Buttons

        #region Logo
        private void Logo_btn_Click(object sender, RoutedEventArgs e)
        {
            facade.OpenLogo();
        }
        #endregion

        #region Generator
        private void OpenGenerator_btn_Click(object sender, RoutedEventArgs e)
        {
            facade.OpenGenerator();
        }

        private void GenerateOptions_btn_Click(object sender, RoutedEventArgs e)
        {
            facade.OpenGeneratorOptions();
        }

        #region Generate options buttons
        private void GenerateOptionsPanel_Generate_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GenerateOptionsPanel_Back_btn_Click(object sender, RoutedEventArgs e)
        {
            facade.OpenGenerator();
        }
        #endregion

        private void CreateOwnOption_btn_Click(object sender, RoutedEventArgs e)
        {
            facade.OpenOptionCreator();
        }

        #region Create own option buttons
        private void CreateOwnOption_Back_btn_Click(object sender, RoutedEventArgs e)
        {
            facade.OpenGenerator();
        }

        private void CreateOwnOption_Erase_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CreateOwnOption_AddTask_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateOwnOption_Save_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
        #endregion

        #region Edit
        private void OpenEdit_btn_Click(object sender, RoutedEventArgs e)
        {
            facade.OpenEditorOption();
        }
        
        private void ChoiceOption_Click(object sender, RoutedEventArgs e)
        {

        }
        #region Edit optional buttons
        private void EditOptionPanel_Save_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditOptionPanel_AddTask_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditOptionPanel_Erase_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #endregion

        #region Results
        private void OpenResults_btn_Click(object sender, RoutedEventArgs e)
        {
            facade.OpenResults();
        }

        private void ChoiceRepository_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #endregion

        #region ScrollViewer

        #region Create own option
        private void CreateOwnOption_ScrollViewer_ScrollChanged(object sender, System.Windows.Controls.ScrollChangedEventArgs e)
        {

        }

        private void CreateOwnOption_ScrollViewer_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            CreateOwnOption_ScrollViewer.ScrollToVerticalOffset(CreateOwnOption_ScrollViewer.VerticalOffset - e.Delta);
            e.Handled = true;
        }
        #endregion

        #region Check result panel
        private void CheckResultPanel_ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {

        }

        private void CheckResultPanel_ScrollViewer_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            CreateOwnOption_ScrollViewer.ScrollToVerticalOffset(CreateOwnOption_ScrollViewer.VerticalOffset - e.Delta);
            e.Handled = true;
        }
        #endregion
        #endregion

        #region Text box input handler
        private void AmountOfOptions_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text, 0);
        }

        #endregion
    }
}