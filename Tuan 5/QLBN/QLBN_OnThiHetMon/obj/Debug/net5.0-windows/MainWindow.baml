   M S B A M L   `   `   `  ����K  GQLBN_OnThiHetMon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:QLBN_OnThiHetMonQLBN_OnThiHetMon  5   	   !    QLBN_OnThiHetMon.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:QLBN_OnThiHetMon     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5       � Title$ 
MainWindow��5   	   $	��550��6   $	��820��6)    � 	Resources 5	         TextBoxStyle �� 
TargetType �� Property �� Value  DataGridColumnHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader  ButtonStyle �� 
TargetType �� Triggers P� Property	 P� Value��%�  &	        &	 z     &	 �     �� 5
   
   " ��6%   .�5      ��  � ��$ Time New Roman)�6+   �� 5       � ��
 ��  �6+   5      �� 5   
   "  62   .�5      ��  � ��$ Center=�6;   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6$   .�5      ��  �@�OverridesDefaultStyle$
 True��66   �� 5       � ��
 �   �6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      A� 
����� �6&   �� 5      $��Center=�6/   $��Center=�5   /   5      5      5       5       P� 5!       �@J�IsMouseOver$
	 True��61   . �5"      ��  � ��
 �����63   �� 5#       � �� 5$      �� 5%      " ��6.   .R�5&   "   � .+�5'   &   A� 
������6.   �� 5(   &   $��Center=�67   $��Center=�5)   /   5*   #   5+      5-      5.      P� 5/       � ��$
	 True��6/   . �50      ��  � ��
 ��ح�63   �� 51       � �� 52      �� 53      " ��6.   .R�54   "   � .+�55   &   A� 
����  �6.   �� 56   &   $��Center=�67   $��Center=�57   /   58   #   59      5;      5<      5>      5?      .��5@      � $	��530��6   $
�� 800��6   .+�5A   
   �� $��Mã bệnh nhân:��5B      $��40��6%   $	��200��61   $��18(�6=   $
��Left=�5C      $	��Top=�6(   $��Center=�5D      $��	10 20 0 0q�6/   �� 5E   
   -   5        
 ��Name$
 txtID��5F      #���   5E      $��40��5F      $	��350��6(   $��18(�64   $
��Left=�5G      $	��Top=�6(   $��Center=�5H      $��
250 20 0 0q�6/   �� 5I   
   $��
Họ tên:��5J      $��40��6   $	��200��6+   $��18(�67   $
��Left=�5K      $	��Top=�6(   $��Center=�5L      $��	10 70 0 0q�6/   �� 5M   
   -   5        $
 txtName��5N      #���   5M      $��40��5N      $	��350��6*   $��18(�66   $
��Left=�5O      $	��Top=�6(   $��Center=�5P      $��
250 70 0 0q�6/   �� 5Q   
   $��Số ngày nằm viện:��5R      $��40��6)   $	��200��65   $��18(�6A   $
��Left=�5S      $	��Top=�6(   $��Center=�5T      $��
10 120 0 0q�6/   �� 5U   
   -   5        $
 txtNum��5V      #���   5U      $��40��5V      $	��350��6)   $��18(�65   $
��Left=�5W      $	��Top=�6(   $��Center=�5X      $��250 120 0 0q�6/   �� 5Y   
   $��Khoa khám:��5Z      $��40��6"   $	��200��6.   $��18(�6:   $
��Left=�5[      $	��Top=�6(   $��Center=�5\      $��
10 170 0 0q�6/   �� 5]   
   -   5         ��Name$	 cbb��5^      $��40��6   $	��350��6&   $��18(�62   $
��Left=�5_      $	��Top=�6(   $��Center=�5`      $��250 170 0 0q�6/   &   System.Windows.Controls.DataGrid  5a   
   -   5          Name$	 dtg��5c         ColumnHeaderStyle# �  5a      $	��180��5c      $	��780��6'   $��16(�63   $��Center=�5d      $	��Top=�6*   $��Center=�5e      $��	0 230 0 0q�6/      AutoGenerateColumns$ False��5f         AlternatingRowBackground
 �����   Columns 5g      0  *System.Windows.Controls.DataGridTextColumn  5h      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã bệnh nhân��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *MaBn+6U     5i      $ 	Họ tên��6%   $	 180 6P    65   �� *HoTen+6P     5j      $ 	Tên khoa��6%   $	 160 6T    67   �� *	TenKhoa+6T     5k      $ Số ngày nằm viện��6%   $	 150 6b    6?   �� *SoNgayNamVien+6b     5l      $ Viện phí��6%   $ * 6P      
FontWeight$
 Bold"�6Z    67   �� *Fee+6Z   5n      �� 5o   
   -   5         ��Name$ btnAdd��5q      #���  5o      $��40��5q      $	��150��6)   $��18(�65   $��Thêm��5r      $��0 440 250 0q�6   $��Center=�5s      $	��Top=�6*   �� 5t   
   -   5        $ 	btnSearch��5v      #���  5t      $��40��5v       $	��150��6,   $��18(�68   $
��Tìm��5w      $��250 440 0 0q�6   $��Center=�5x      $	��Top=�6*   5y      5z      