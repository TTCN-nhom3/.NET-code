   M S B A M L   `   `   `  ����K  GQLBN_OnThiHetMon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:QLBN_OnThiHetMonQLBN_OnThiHetMon  5   	   "    QLBN_OnThiHetMon.ExtraWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:QLBN_OnThiHetMon     5   	     � Title$  ExtraWindow��5   	   $	��450��6   $	��800��6*    � 	Resources 5	         DataGridColumnHeaderStyle �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Property �� Value��%|   &	        �� 5
   
   "  62   .�5      ��  � ��$ Center=�6;   �� 5       � ��$
 Bold"�6+   5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$	 dtg��5         ColumnHeaderStyle# �   5      $	��180��5      $	��780��6'   $��16(�63   $��Center=�5      $	��Top=�6*   $��Center=�5      $��0 30 0 0q�6/      AutoGenerateColumns$ False��5         AlternatingRowBackground
 �����	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Mã bệnh nhân��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *MaBn+6U     5      $
 	Họ tên��6%   $	 180 6P    65   �� *HoTen+6P     5      $
 	Tên khoa��6%   $	 160 6T    67   �� *	TenKhoa+6T     5      $
 Số ngày nằm viện��6%   $	 150 6b    6?   �� *SoNgayNamVien+6b     5      $
 Viện phí��6%   $ * 6P      
FontWeight$
 Bold"�6Z    67   �� *Fee+6Z   5      5      5      