   M S B A M L   `   `   `  ����E  AMISBolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MISBolnica
MISBolnica  5          MISBolnica.Otkazi   5      U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MISBolnica     5      -   5          N� Title$!  О разработчике��5
       N� 
Background
 ����� N� FontSize$ 20(�5       N� 
FontFamily$ Champagne & Limousines)�5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��400 �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Center=�6"   .+�5      �� -   5         ��Name$ currentTextHeader��5      $��Center=�63   1/Отказы от госпитализации:6k   5      �� 5   
   $��0��6   $��Center=�6"   .+�5      �� -   5         ��Name$ buttonPrint��5      $��	10 0 15 0q�6*    � ToolTip$# Печать эпикриза��6=   $��Right=�6W   $��50��6s   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=�6*   5      5      �� 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 DataGridPacient��5      $	��400��60   $	��765��6=   
   SelectionMode$
 Single=�6I      
IsReadOnly . 5       5!      (  "MaterialDesignThemes.Wpf.ColorZone  5"   
   $��	10 10 0 0q�6#      Mode$ Light=�66   $��2��6C      CornerRadius$ 2��6P   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�6a   $	��750��6�   $
��Left=�6�   .��5#      ��  �� Orientation$ 
Horizontal=�6   $��10q�62   .+�5$      �� -   5         ��Name$ textFind��5$      $��5 0 5 0q�6-   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$3 -Введите ФИО для поиска ...��6>   $	��200��6z   6�   �� 5%      -   5        $ 
buttonFind��5%      $��40 0 5 0q�6-   $" Найти в таблице��6?   .��5&        $ Search=�6.   5'      �� 5(      -   5        $ buttonFindCancel��5(      $��25 0 5 0q�63   $! Отменить поиск��6E   .��5)        $ Clear=�6.   5*      �� 5+      -   5        $ buttonEditPacient��5+      $��25 0 5 0q�64   $# Изменить запись��6F   .��5,        $
 Edit=�6.   5-      �� 5.      -	   5        $ buttonDelete��5.      $��25 0 5 0q�6/   $! Удалить запись��6A   .��5/        $ Delete=�6.   50      �� 51      -
   5        $ buttonShoPacient��51      $��25 0 5 0q�63   $? 9Показать информацию о пациенте��6E   .��52        $
 Show=�6.   53      �� 54      -   5        $ buttonPrintEpikriz��54      $��25 0 5 0q�65   $? 9Показать информацию о пациенте��6G   .��55        $ 
PrinterPos=�6.   56      58      59      5:      5;      