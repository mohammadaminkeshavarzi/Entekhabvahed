   M S B A M L   `   `   `  ����M  IEntekhab_Vahed_Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Entekhab_Vahed_WpfEntekhab_Vahed_Wpf  5   	       Entekhab_Vahed_Wpf.Lesson   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Entekhab_Vahed_Wpf     5   	   -   5          � Title$  دروس��5   	   $	��500��6   $	��600��6#    � WindowStartupLocation$ CenterScreen=�6/    � 
ResizeMode$ NoResize=�6T   .��5	      � ���	#FF71B1C0$��RightToLeft=�6"   .+�5
   
   �� -   5         ��Name$ label��5
      $��کددرس :��6   $��	18,20,0,0q�61   $	��Top=�6D   $��94��6\   $��IRANSans)�6g   $��13(�6}   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5         ��Name$ txtCode��5      $
��Left=�6#   $��26��6>   $��
112,21,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��178��6�   $��Stretch=�6�   {�.   �� TextAlignment$ Center=�6�   �� 5   
   -   5         ��Name$ btnSave��5      $��ثبت درس��6"   $
��Left=�64   $��
17,150,0,0q�6O   $	��Top=�6c   $	��559��6{   $��38��6�   ���	#FF29863E
�������$��14(�6�   $��IRANSans)�6�   $��Oblique$�6�   $��Expanded&�6�   $
��Bold"�6  6  �� 5   
   -   5        $ 
label_Copy��5      $��نام درس :��6$   $��	18,64,0,0q�68   $	��Top=�6K   $��94��6c   $��IRANSans)�6n   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��26��6>   $��
112,65,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��178��6�   $��Stretch=�6�   �� 5   
   -   5        $ label_Copy1��5      $��واحد درس :��6%   $��
18,106,0,0q�6:   $	��Top=�6N   $��94��6f   $��IRANSans)�6q   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $ label_Copy4��5      $��رشته درس :��6%   $��
299,17,0,0q�6:   $	��Top=�6N   $��94��6f   $��IRANSans)�6q   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -	   5         ��Name$ cmbField��5      $
��Left=�6%   $��
398,17,0,0q�6@   $	��Top=�6T   $	��178��6l   $��30��6x   �� 5   
   -
   5        $ label_Copy5��5      $��استاد درس :��6%   $��
299,64,0,0q�6;   $	��Top=�6O   $��94��6g   $��IRANSans)�6r   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $ cmbProf��5      $
��Left=�6$   $��
398,64,0,0q�6?   $	��Top=�6S   $	��178��6k   $��30��6w   �� 5   
   -   5        $ txtUnit��5      $
��Left=�6#   $��26��6>   $��112,110,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��178��6�   $��Stretch=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dataGrid��5      $
��Left=�6%   $��
17,205,0,0q�6@   $	��Top=�6T   $	��194��6l   $	��559��6y   �� 5   
   -   5        $ btnDell��5      $��حذف درس��6"   $
��Left=�64   $��
17,413,0,0q�6O   $	��Top=�6c   $	��559��6{   $��38��6�   ���	#FFB63939���	#FF861414
�������$��14(�6�   $��IRANSans)�6�   6�   5      5      