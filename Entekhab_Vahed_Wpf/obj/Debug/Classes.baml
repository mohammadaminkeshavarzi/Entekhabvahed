   M S B A M L   `   `   `  ����M  IEntekhab_Vahed_Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Entekhab_Vahed_WpfEntekhab_Vahed_Wpf  5   	        Entekhab_Vahed_Wpf.Classes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Entekhab_Vahed_Wpf     5   	   -   5          � Title$  کلاس ها��5   	   $	��550��6   $	��600��6&    � WindowStartupLocation$ CenterScreen=�62    � 
ResizeMode$ NoResize=�6W   .��5	      � ���	#FF71B1C0$��RightToLeft=�6"   .+�5
   
   �� -   5         ��Name$ label��5
      $��کد کلاس :��6   $��	18,20,0,0q�63   $	��Top=�6F   $��94��6^   $��IRANSans)�6i   $��13(�6   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5         ��Name$ txtCode��5      $
��Left=�6#   $��26��6>   $��
112,21,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��178��6�   $��Stretch=�6�   {�.   �� TextAlignment$ Center=�6�   �� 5   
   -   5         ��Name$ btnSave��5      $��ثبت کلاس��6"   $
��Left=�65   $��
17,211,0,0q�6P   $	��Top=�6d   $	��559��6|   $��38��6�   ���	#FF29863E
�������$��14(�6�   $��IRANSans)�6�   $��Oblique$�6�   $��Expanded&�6�   $
��Bold"�6  6  �� 5   
   -   5        $ 
label_Copy��5      $��نام کلاس :��6$   $��	18,64,0,0q�69   $	��Top=�6L   $��94��6d   $��IRANSans)�6o   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��26��6>   $��
112,65,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��178��6�   $��Stretch=�6�   �� 5   
   -   5        $ label_Copy4��5      $��نام درس :��6%   $��
299,17,0,0q�69   $	��Top=�6M   $��94��6e   $��IRANSans)�6p   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5         ��Name$ 	cmbLesson��5      $
��Left=�6&   $��
398,17,0,0q�6A   $	��Top=�6U   $	��178��6m   $��30��6y   �� 5   
   -	   5        $ label_Copy5��5      $��استاد کلاس :��6%   $��
299,64,0,0q�6<   $	��Top=�6P   $��94��6h   $��IRANSans)�6s   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -
   5        $ cmbProf��5      $
��Left=�6$   $��
398,64,0,0q�6?   $	��Top=�6S   $	��178��6k   $��30��6w   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dataGrid��5      $
��Left=�6%   $��
17,254,0,0q�6@   $	��Top=�6T   $	��214��6l   $	��559��6y   �� 5   
   -   5        $ btnDell��5      $��حذف کلاس��6"   $
��Left=�65   $��
17,473,0,0q�6P   $	��Top=�6d   $	��559��6|   $��38��6�   ���	#FFB63939���	#FF861414
�������$��14(�6�   $��IRANSans)�6�   6�   �� 5   
   -   5        $ label_Copy2��5      $��ظرفیت کلاس :��6%   $��295,106,0,0q�6<   $	��Top=�6Q   $��94��6i   $��IRANSans)�6t   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $ txtCapecity��5      $
��Left=�6'   $��26��6B   $��398,110,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��178��6�   $��Stretch=�6�   �� 5   
   -   5        $ label_Copy3��5      $"��تاریخ برگزاری  :��6%   $��
18,106,0,0q�6@   $	��Top=�6T   $��94��6l   $��IRANSans)�6w   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $ txtDate��5      $
��Left=�6#   $��26��6>   $��112,111,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��178��6�   $��Stretch=�6�   $��
1399/05/06��6�   �� 5   
   -   5        $ label_Copy6��5      $ ��ساعت برگزاری  :��6%   $��
10,149,0,0q�6?   $	��Top=�6S   $��94��6k   $��IRANSans)�6v   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $ txtTime��5      $
��Left=�6#   $��26��6>   $��112,153,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��178��6�   $��Stretch=�6�   $��12:20��6�   �� 5   
   -   5        $ label_Copy7��5      $��محل برگزاری :��6%   $��299,149,0,0q�6=   $	��Top=�6R   $��94��6j   $��IRANSans)�6u   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5        $ txtMakan��5      $
��Left=�6$   $��26��6?   $��398,153,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��178��6�   $��Stretch=�6�   5      5      