   M S B A M L   `   `   `  ����E  AMISBolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MISBolnica
MISBolnica  5   	       MISBolnica.Login   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MISBolnica     5   	   U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5	   	   $	��500��6   $	��350��6$    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   $��Segoe UI Emoji)�5   	   .��5      � .+�5   
   �� -   5        $	��280��5      $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $ 0.546Q�65   5      5      �� 5   
   $	��280��6   $	��240��6    $��Bottom=�6-   $
��0,80q�6H    �� RadiusY$ 10��6V   	 �� RadiusX$	 10��6c   
�������
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      � 5   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�5       �� $��АВТОРИЗАЦИЯ��6   $��Center=�6*   $	��Top=�6G   $��5q�6_   
�������$��18(�6|   �� 5!      $��Center=�6   $��15q�64   .+�5"      �� -   5        $��	textLogin��5"      $
��0,10q�6+   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
ЛОГИН��69    %  !MaterialDesignFloatingHintTextBox#��[  6`   $��Champagne & Limousines)�6�   $��18(�6�   G� 5#      -   5        $��textPassword��5#      $
��0,10q�62   $ ПАРОЛЬ��6@    ) %MaterialDesignFloatingHintPasswordBox#��[ 6h   $��Champagne & Limousines)�6�   $��18(�6�   5$      5%      �� 5&   
   -   5        $��VoitiButton��5&      $	��100��6$   $
��Left=�60   $��Bottom=�6K   $��50,65q�6f   $��
ВОЙТИ��6u    �� 	IsDefault . 6�   �� 5'   
   -   5        $��
ExitButton��5'      $	��100��6#   $��Right=�6/   $��Bottom=�6K   $��50,65q�6f   $��ОТМЕНА��6u   6�   �� 5(   
   $H��BУЗ Брестская городская больница СМП��6   $��Center=�6?   $��Bottom=�6\   $��30q�6w   
�������6�   '  !MaterialDesignThemes.Wpf.PackIcon  5)   
      Kind$ HealthPotionOutline=�6"   $	��100��6=   $	��100��6I   $	��Top=�6V   $��
125 50 0 0q�6n   
�������6�   5*      5+      