   M S B A M L   `   `   `  ���� E  AMISBolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MISBolnica
MISBolnica      MISBolnica.MainForm   U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:MISBolnica     -   $	��600��$
��1024��  � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�
�������.��� -   ���	#FFEEEEEE.+��� $	��Top=�
�������.+�� 
�������$��10��� $��5q�
�������.+��� $��Center=� �� Orientation$ 
Horizontal=�$��246,0,166,0q�.+��� $[��UРабочее место врача реаниматолога в УЗ БГБ СМП��$��Center=�$��20(�$��Champagne & Limousines)�$
��20 0q��� $��Center=�$��5 0 0 0q�.+��� $��СРАВОЧНИКИ���� $��30��$��30��$��0q�
���������Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PopupBox   � ToolTip$; 5Редактирование справочников��   PopupContent. �� $	��150�� � Cursor$
 Hand��.+��� -    ��Name$ 	buttonMkb��$��МКБ���� -   $ buttonOtdelenia��$��Отделения���� $ 
Horizontal=�$��Right=�$
��10 0q�.+��� -   $ copyBase��$��30��$��30��$��0q�
�������$4 .Резервное копирование БД����Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ DatabaseTick=��� -   $ settingsButton��$��30��$��30��$��0q�
�������$+ %Настройки программы����Z� ��Z� .��  $ Settings=��� -   $ ExitUserButton��$��30��$��30��$��0q�
�������$��0 0 10 0q�$- 'Сменить пользователя����Z� ��Z� .��  $ ExitRun=��� -   $ ButtonFechar��$��30��$��30��$��0q�
�������$' !Закрыть программу����Z� ��Z� .��  $ Power=�� $��
250 45 0 0q�	 � ColumnDefinitions	 �� $��7* ��� $��2* �.+� � -	   
  �Name$
 Frame��  � NavigationUIVisibility$ Hidden=�$��2��� $	��250��$
��Left=����	#FF222222 � RowDefinitions �� $��9* ��� $
��191* �.+�?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -
     Name$ TrainsitionigContentSlide��$��2��C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��� -    �Name$ 
GridCursor��$��	0 100 0 0q����	#FF0069C0$��10��$
��Left=�$��60��$	��Top=��� -    ��Name$ ListViewMenu��$��
0,73,0,100q�
�������$��Champagne & Limousines)�$��18(� �� SelectedIndex$ 0��$��1��$
 Hand��.@��� $��60��.���� $ 
Horizontal=�.+�  $
 Home=�$��30��$��30��$��Center=�$��5q��� $%��ТЕКУЩИЕ ПАЦИЕНТЫ��$��17(�$��Center=�$
��20 0q��� $��60��.���� $ 
Horizontal=�.+�  $ Error=�$��30��$��30��$��Center=�$��5q��� $��ОТКАЗЫ��$��17(�$��Center=�$
��20 0q��� $��60��.���� $ 
Horizontal=�.+�  $ 	TruckTick=�$��30��$��30��$��Center=�$��5q��� $��ВЫПИСАНЫЕ��$��17(�$��Center=�$
��20 0q��� $��60��.���� $ 
Horizontal=�.+�  $ FormatListBulleted=�$��30��$��30��$��Center=�$��5q��� $��ОТЧЕТЫ��$��17(�$��Center=�$
��20 0q��� $��60��.���� $ 
Horizontal=�.+�  $ Settings=�$��30��$��30��$��Center=�$��5q��� $��НАСТРОЙКИ��$��17(�$��Center=�$
��20 0q��� $��60��.���� $ 
Horizontal=�.+�  $ AccountStar=�$��30��$��30��$��Center=�$��5q��� $!��О РАЗРАБОТЧИКЕ��$��17(�$��Center=�$
��20 0q�� $��20��$��Bottom=����	#FFEEEEEE.+��� $ 
Horizontal=�$��10 0 0 0q�.+��� $��18(�$��Champagne & Limousines)�+)Вы вошли в систему как:�� -    ��Name$ textCurrentUser��$��18(�$��Champagne & Limousines)��� $��18(�$��Champagne & Limousines)�Ваш логин:�� -   $ textCurrentLogin��$��18(�$��Champagne & Limousines)��� $��18(�$��Champagne & Limousines)�Сегодня:�� -   $ textCurrentDate��$��18(�$��Champagne & Limousines)�