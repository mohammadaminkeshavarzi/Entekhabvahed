   M S B A M L   `   `   `  ����M  IEntekhab_Vahed_Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Entekhab_Vahed_WpfEntekhab_Vahed_Wpf  5   	        Entekhab_Vahed_Wpf.Student   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Entekhab_Vahed_Wpf     5   	   -   5          � Title$  دانشجو��5   	   $	��500��6   $	��600��6%    � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�6V   .��5	      � ���	#FF71B1C0$��RightToLeft=�6"   .+�5
   
   �� -   5         ��Name$ label��5
      $��کد دانشجو :��6   $��	18,27,0,0q�65   $	��Top=�6H   $��94��6`   $��IRANSans)�6k   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5         ��Name$ txtCode��5      $
��Left=�6#   $��26��6>   $��
112,27,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��178��6�   $��Stretch=�6�   {�.   �� TextAlignment$ Center=�6�   �� 5   
   -   5         ��Name$ btnSave��5      $��ثبت دانشجو��6"   $
��Left=�67   $��
18,200,0,0q�6R   $	��Top=�6f   $	��559��6~   $��38��6�   ���	#FF29863E
�������$��14(�6�   $��IRANSans)�6�   $��Oblique$�6�   $��Expanded&�6�   $
��Bold"�6  6!  �� 5   
   -   5        $ 
label_Copy��5      $��نام دانشجو :��6$   $��	18,71,0,0q�6;   $	��Top=�6N   $��94��6f   $��IRANSans)�6q   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��26��6>   $��
112,71,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��178��6�   $��Stretch=�6�   �� 5   
   -   5        $ label_Copy1��5      $��نام خانوادگی :��6%   $��
18,117,0,0q�6>   $	��Top=�6R   $��94��6j   $��IRANSans)�6u   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $ txtLName��5      $
��Left=�6$   $��26��6?   $��112,117,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��178��6�   $��Stretch=�6�   �� 5   
   -	   5        $ label_Copy2��5      $��نام پدر :��6%   $��
18,165,0,0q�69   $	��Top=�6M   $��94��6e   $��IRANSans)�6p   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -
   5        $ 	txtFather��5      $
��Left=�6%   $��26��6@   $��112,165,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��178��6�   $��Stretch=�6�   �� 5   
   -   5        $ label_Copy3��5      $��کد ملی :��6%   $��304,117,0,0q�68   $	��Top=�6M   $��94��6e   $��IRANSans)�6p   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $ txtCodM��5      $
��Left=�6#   $��26��6>   $��398,117,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��178��6�   $��Stretch=�6�    �� 	MaxLength$ 10��6�   �� 5   
   -   5        $ label_Copy4��5      $��مقطع تحصیلی :��6%   $��
299,24,0,0q�6=   $	��Top=�6Q   $��94��6i   $��IRANSans)�6t   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        	 ��Name$	 	cmbDegree��5      $
��Left=�6&   $��
398,24,0,0q�6A   $	��Top=�6U   $	��178��6m   $��30��6y   .@�5      �� -   5        $
��cbi1��5      .��6'   کاردانی60   �� 5      -   5        $
��cbi2��5      .��6'   کارشناسی61   �� 5      -   5        $
��cbi3��5      .��6'   کارشناسی ارشد66   �� 5      -   5        $
��cbi4��5      .��6'   
دکتری6.   5      �� 5   
   -   5        $ label_Copy5��5      $��رشته تحصیلی :��6%   $��
299,71,0,0q�6=   $	��Top=�6Q   $��94��6i   $��IRANSans)�6t   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $	 cmbField��5      $
��Left=�6%   $��
398,71,0,0q�6@   $	��Top=�6T   $	��178��6l   $��30��6x   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 dataGrid��5      $
��Left=�6%   $��
17,243,0,0q�6@   $	��Top=�6T   $	��174��6l   $	��559��6y   �� 5   
   -   5        $ btnDell��5      $��حذف دانشجو��6"   $
��Left=�67   $��
17,422,0,0q�6R   $	��Top=�6f   $	��559��6~   $��38��6�   ���	#FFB63939���	#FF861414
�������$��14(�6�   $��IRANSans)�6�   6�   5!      5"      