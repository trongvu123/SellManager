   M S B A M L   `   `   `  ����F  BSellManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SellManagerSellManager  5   	   '    !SellManager.CustomerManagerWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SellManager     5   	     N� Title$  CustomerManagerWindow��5   	   $	��450��6'   $	��800��64   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $
��Left=�61   $��	20,18,0,0q�6L   $
��Wrap=�6_   $��Mã KH��6s   $	��Top=�6�   $��16(�6�   �� 5   
   -   5         ��Name$ txtMakh��5      $��0��6#   $��1��60   $
��Left=�6@   $��	10,18,0,0q�6[    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��147��6�   �� 5   
   $��0��6   $��2��6!   $
��Left=�61   $��	10,18,0,0q�6L   $
��Wrap=�6_   $��Thành phố��6s   $	��Top=�6�   $��16(�6�   �� 5   
   -   5         ��Name$ cboThanhpho��5      $��0��6(   $��3��65   $
��Left=�6E   $��	10,18,0,0q�6`   $	��Top=�6s   $	��177��6�   6�   �� 5   
   $��1��6   $��0��6!   $
��Left=�61   $��	20,18,0,0q�6L   $
��Wrap=�6_   $��Khách hàng��6s   $	��Top=�6�   $��16(�6�   �� 5   
   -   5        $ txtKhachhang��5      $��1��6(   $��1��65   $
��Left=�6E   $��	10,18,0,0q�6`   $
 Wrap=�6s   $	��Top=�6�   $	��255��6�   �� 5!   
   $��1��6   $��2��6!   $
��Left=�61   $��	10,18,0,0q�6L   $
��Wrap=�6_   $��Điện thoại��6s   $	��Top=�6�   $��16(�6�   �� 5"   
   -   5        $ txtDienthoai��5"      $��1��6(   $��3��65   $
��Left=�6E   $��	10,18,0,0q�6`   $
 Wrap=�6s   $	��Top=�6�   $	��177��6�   �� 5$   
   $��2��6   $��0��6!   $
��Left=�61   $��	20,18,0,0q�6L   $
��Wrap=�6_   $��Địa chỉ��6s   $	��Top=�6�   $��16(�6�   �� 5%   
   -   5        $ 	txtDiachi��5%      $��2��6%   $��1��62   $
��Left=�6B   $��	10,18,0,0q�6]   $
 Wrap=�6p   $	��Top=�6�   $	��255��6�   &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ DgData��5'   D   $��3��6   $��0��6    $��4��60      AutoGenerateColumns$ False��6T   $��20,10,20,10q�6p      Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn	   Header$	 MãKH��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *MaKh+  5*      $	 KHÁCH HÀNG��6%   $
 * 69    6C   �� *TenCty+  5+      $	 ĐỊA CHỈ��6%   $
 * 66    6@   �� *DiaChi+  5,      $	 ĐIỆN THOẠI��6%   $
 * 69    6C   �� *	DienThoai+4  .System.Windows.Controls.DataGridComboBoxColumn  5-      -   5        colCity��$	 THÀNH PHỐ��5-   :   $
 * 6M      DisplayMemberPath$ TenThanhPho��5/         SelectedValuePath$ 
MaThanhPho��50         SelectedValueBinding 5.      �� *
MaThanhPho+   ElementStyle 51      �� 52       �� 
TargetType" ��6    .�53      ��  �� Property � �� �� Value 6<   ��  �� Path$  DataContext.ListOfCategory� �� RelativeSource �� *FindAncestor+ �� AncestorType"  56         EditingElementStyle 58      �� 59      " ��6    .�5:      ��  � �� 6<   �� $  DataContext.ListOfCategory� �� *FindAncestor+"  5=      5?      5A      �� 5C   
   $��4��6   $��1��6"   $��3��62    �� Orientation$ 
Horizontal=�6F   $
��Left=�6_   $��52,5,0,5q�6z   .+�5D      �� -   5        $��Thêm��5D      $��0,0,10,0q�6$   $��71��66   6A   �� 5E      -	   5        $��Sửa��5E      $��0,0,10,0q�6#   $��71��65   6@   �� 5F      $
��Lưu��6   $��0,0,10,0q�6#   $��71��65   �� 5G      -
   5        $��Hủy��5G      $��0,0,10,0q�6#   $��71��65   6@   �� 5H      -   5        $
��Xóa��5H      $��0,0,10,0q�6#   $��71��65   6@   �� 5I      $��Tải lại��6   $��71��6'   5J      5K      5L      