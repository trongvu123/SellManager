   M S B A M L   `   `   `  ����F  BSellManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SellManagerSellManager  5   	   #    SellManager.CreateOrderWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SellManager     5   	     N� Title$  CreateOrderWindow��5   	   $	��450��6#   $	��800��60   .��5	      � .+�5
   
   �� $��0,28,0,0q�6   $
��Wrap=�6&   $!��LẬP HÓA ĐƠN BÁN HÀNG��6:   $��Center=�6V   $	��Top=�6s   $��20(�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��	83,78,0,0q�6/   $
��Wrap=�6B   $��Khách hàng��6V   $	��Top=�6h   $��18(�6�   �� 5   
   -   5         ��Name$ cbokhachang��5      $��Center=�6(   $��0,79,0,0q�6E   $	��Top=�6W   $	��396��6o   6{   �� 5   
   $
��Left=�6   $��
83,127,0,0q�6/   $
��Wrap=�6C   $��Mã hóa đơn��6W   $	��Top=�6i   $��18(�6�   �� 5   
   -   5         ��Name$ txtMahd��5      $
��Left=�6#   $��202,133,0,0q�6>    �� TextWrapping$
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $	��118��6�   ���	#FFDF1A1A$��18��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgData��5   #   $��0��6      AutoGenerateColumns$ False��63   $��83,182,65,57q�6O   ��6�   �� *OrderDetails+   Columns 5      4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        
colSanpham��,  &System.Windows.Controls.DataGridColumn   Header$ Sản phẩm��5   =      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6O   	   DisplayMemberPath$	 TenSp��5      
   SelectedValuePath$

 MaSp��5         SelectedValueBinding 5      �� *MaSp+   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value 6<   ��  �� Path$  DataContext.ListOfCategory� �� RelativeSource �� *FindAncestor+ �� AncestorType"  5         EditingElementStyle 5      �� 5      " ��6    .�5      ��  � �� 6<   �� $  DataContext.ListOfCategory� �� *FindAncestor+"  -   5        5#      5%      0  *System.Windows.Controls.DataGridTextColumn  5&      $ Số lượng��6%   $ * 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *	SoLuong+ �� UpdateSourceTrigger$ PropertyChanged=�  5'      $ 
Đơn giá��6%   $ * 66      
IsReadOnly$
 True��6[    6@   �� *DonGia+6[     5(      $ Thành tiền��6%   $ * 69   $
 True��6a    6C   �� *	ThanhTien+6a   5+      �� 5,   
   -   5        $��Tạo hóa đơn��5,      $
��Left=�6'   $��588,394,0,0q�6B   $	��Top=�6W   $��30��6o   $	��147��6{   6�   5-      5.      