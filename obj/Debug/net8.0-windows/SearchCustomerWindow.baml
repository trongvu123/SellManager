   M S B A M L   `   `   `  ����F  BSellManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SellManagerSellManager  5   	   &     SellManager.SearchCustomerWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SellManager     5   	     N� Title$  SearchCustomerWindow��5   	   $	��450��6&   $	��800��63   .��5	      � .+�5
   
   �� $
��Left=�6   $��	44,30,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��18(�6n   �� 6}    � Language$ vi-vn�6�   $�Thành Phố��6�   6�   �� 5   
   -   5         ��Name$ cboCity��5      $
��Left=�6$   $��
143,30,0,0q�6?   $	��Top=�6S   $	��149��6k   $��31��6w   6�   �� 5   
   $
��Left=�6   $��
480,34,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��18(�6o   �� 6~   $ vi-vn�6�   $ �Số lượng khách hàng��6�   6�   �� 5   
   -   5         ��Name$ txtCount��5      $
��Left=�6$   $��
664,40,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $��TextBox��6g   $	��Top=�6v   $��50��6�   $��21��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgData��5   B   $��	0,116,0,0q�6      AutoGenerateColumns$ False��6&      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ MãKH��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 63   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6=   �� *MaKh+  5      $ KHÁCH HÀNG��6%   $	 * 69   
 6C   �� *TenCty+  5      $ ĐỊA CHỈ��6%   $	 * 66   
 6@   �� *DiaChi+  5      $ ĐIỆN THOẠI��6%   $	 * 69   
 6C   �� *	DienThoai+  5      $ MÃ THÀNH PHỐ��6%   $	 * 6;   
 6E   �� *
MaThanhPho+5      5      5      