   M S B A M L   `   `   `  ����F  BSellManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SellManagerSellManager  5   	   #    SellManager.OrderManageWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SellManager     5   	     N� Title$  OrderManageWindow��5   	   $	��450��6#   $	��800��60   .��5	      � .+�5
   
   �� $
��Left=�6   $��	16,20,0,0q�6/   $
��Wrap=�6B   $��Thành phố��6V   $	��Top=�6g   $��14(�6   �� 5   
   -   5         ��Name$ cboThanhpho��5      $
��Left=�6(   $��	96,19,0,0q�6C   $	��Top=�6V   $	��142��6n   6z   �� 5   
   $
��Left=�6   $��
280,21,0,0q�6/   $
��Wrap=�6C   $��Khách hàng��6W   $	��Top=�6i   $��14(�6�   �� 5   
   -   5        $ cboKhachhang��5      $
��Left=�6)   $��
363,18,0,0q�6D   $	��Top=�6X   $	��131��6p   6|   �� 5   
   $
��Left=�6   $��
540,22,0,0q�6/   $
��Wrap=�6C   $ ��Số lượng khách hàng��6W   $	��Top=�6r   �� 5   
   -   5         ��Name$ txtSlKhachhang��5      $
��Left=�6*   $��
666,19,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $�� ��6m   $	��Top=�6u   $��68��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgData��5   #   $��0��6      AutoGenerateColumns$ False��63   $��
0,54,0,243q�6O      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ MãHĐ��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *MaHd+  5      $ KHÁCH HÀNG��6%   $ * 69   	 6C   �� *	KhachHang+  5      $ Ngày lập HĐ��6%   $ * 6:   	 6D   �� *	NgayLapHd+  5      $ Ngày nhận hàng��6%   $ * 6=   	 6G   �� *NgayNhanHang+  5      $ Nhân viên lập HĐ��6%   $ * 6?   	 6I   �� *
NhanVien+5        5   
   -   5        $ DgData2��5   #   $��0��6   $ False��64   $��
0,241,0,48q�6P    5        5      $ MãHĐ��6%   $ * 63   	 6=   �� *MaHd+  5      $ Sản phẩm��6%   $ * 67   	 6A   �� *	SanPham+  5      $ Số lượng��6%   $ * 67   	 6A   �� *	SoLuong+  5      $ 
Đơn giá��6%   $ * 66   	 6@   �� *DonGia+  5       $ Thành tiền��6%   $ * 69   	 6C   �� *	ThanhTien+5#      �� 5$   
   $
��Left=�6   $��	573,0,0,0q�6/   $
��Wrap=�6B   $��Số lượng hóa đơn��6V   $��Center=�6n   $��16(�6�   �� 5%   
   -   5        $ txtSlHoadon��5%      $
��Left=�6'   $��	712,0,0,0q�6B   $
 Wrap=�6U   $�� ��6i   $��Center=�6q   $��53��6�   $��21��6�   �� 5&   
   $
��Left=�6   $��565,409,0,0q�6/   $
��Wrap=�6D   $��Số lượng mặt hàng��6X   $	��Top=�6q   $��16(�6�   �� 5'   
   -   5        $ txtSlMathang��5'      $
��Left=�6(   $��728,408,0,0q�6C   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $��47��6�   $��24��6�   5)      5*      