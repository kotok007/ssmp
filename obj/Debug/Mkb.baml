   M S B A M L   `   `   `  ����E  AMISBolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MISBolnica
MISBolnica  5          MISBolnica.Mkb   5      U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MISBolnica     5      -   5          N� Title$!  О разработчике��5
       N� 
Background
 ����� N� FontSize$ 20(�5       N� 
FontFamily$ Champagne & Limousines)�5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��300 �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Center=�6"   .+�5      �� -   5         ��Name$ currentTextHeader��5      $��Center=�63   Справочник МКБ:6a   5      �� 5   
   $��0��6   $��Center=�6"   .+�5      �� -   5         ��Name$ buttonPrint��5      $��	10 0 15 0q�6*    � ToolTip$ Печать��6=   $��Right=�6N   $��50��6j   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=�6*   5      5      �� 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 DataGridMkb��5      $	��300��6,   
   SelectionMode$
 Single=�69   5       5!      #  MaterialDesignThemes.Wpf.Card  5"   
   $��2��6   $	��155��6+   $��10q�68   
�������+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�6W   .��5#      �  5$      �� 5%      $��70 �6$   �� 5&      $
��Auto �6$   .+�5(      (  "MaterialDesignThemes.Wpf.ColorZone  $��	10 10 0 0q�6+      Mode$ Light=�6>   $��0��6K      CornerRadius$ 2��6X   $ Depth4=�6i   $	��730��6�   $
��Left=�6�   .��5)      ��  �� Orientation$ 
Horizontal=�6!   $��10q�6:   .+�5*      �� -   5         ��Name$ textFind��5*   "   $��5 0 5 0q�65   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$9 3Введите то, что надо найти ...��6F   $	��522��6�   6�   �� 5+      -   5        $ 
buttonFind��5+   !   $��25 0 5 0q�65   $" Найти в таблице��6`   .��5,        $ Search=�66   5-      �� 5.      -   5        $ buttonFindCancel��5.   !   $��25 0 5 0q�6;   $! Отменить поиск��6l   .��5/        $ Close=�66   50      51      52        53      $��	12,15,0,0q�6+   $ Light=�6>   $��1��6K   $ 2��6X   $ Depth4=�6i   $	��730��6�   $
��Left=�6�   .��54      �� $ 
Horizontal=�6!   $��10q�6:   .+�55      �� -   5        $ 
textKodMkb��55   "   $��5 0 5 0q�66   $&  Введите код МКБ ...��6G   $	��250��6|   6�   �� 57      -	   5        $ textNazvanie��57   "   $��15 0 5 0q�68   $5 /Введите название по МКБ ...��6J   $	��250��6�   6�   �� 58      -
   5        $ 	buttonAdd��58   !   $��25 0 5 0q�64   $# Добавить запись��6^   .��59        $	 Add=�66   5:      5;      �� 5<      -   5        $ buttonDelete��5<   !   $��25 0 5 0q�67   $! Удалить запись��6d   .��5=        $ Delete=�66   5?      5@      5A      5B      5C      5D      5E      5F      