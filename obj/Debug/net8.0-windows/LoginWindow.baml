   M S B A M L   `   `   `  ����F  BSellManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SellManagerSellManager  5   	       SellManager.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SellManager     5   	     � Title$  LoginWindow��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	   ���#2C3E50.��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��3��6!   $��Login��65   $��24(�6B   
�������$
��Bold"�6c   $
��Left=�6u   $	��Top=�6�   $��
368,25,0,0q�6�   �� 5   
   $��1��6   $��3��6   ���#34495E �� CornerRadius$ 10��5   &    J� Opacity$	 0.9Q�68    �� Padding$ 20q�6F   $
��Left=�5       $	��Top=�6,   $��
237,62,0,0q�6D   $��2��6X   ._�5!      �  5"      �� 5#      $
��Auto �6$   �� 5$      $
��Auto �6$   �� 5%      $
��Auto �6$    5'      �� 5(      $
��Auto �6'   �� 5)      $��* �6'   .+�5-      �� $��0��6   $��0��6%   $��	Username:��65   
�������$��Center=�6\   $��5q�6w   �� 5.      -   5        $��txtUsername��5.   7   $��0��6   $��1��6'   $	��200��6J   $��5q�6V   �� 51      $��1��6   $��0��6%   $��	Password:��65   
�������$��Center=�6\   $��5q�6w   G� 52      -   5        $��txtPassword��52   ;   $��1��6   $��1��6+   $	��200��6N   $��5q�6Z   �� 55      -   5        $��2��55      $��1��6&   $��Login��66   $��75��6F   $��5q�6Q   $��Right=�6\   6x   56      57      58      59      