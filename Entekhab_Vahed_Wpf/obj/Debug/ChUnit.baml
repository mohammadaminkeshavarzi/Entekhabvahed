   M S B A M L   `   `   `  ����M  IEntekhab_Vahed_Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Entekhab_Vahed_WpfEntekhab_Vahed_Wpf  5   	       Entekhab_Vahed_Wpf.ChUnit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Entekhab_Vahed_Wpf     5   	     � Title$  انتخاب واحد��5   	   $	��550��6   $	��600��6*    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ NoResize=�6[   .��5	      � ���	#FF71B1C0$��RightToLeft=�6"   .+�5
   
   �� -   5         ��Name$ btnSave��5
      $��انتخاب و ثبت��6"   $
��Left=�69   $��
10,227,0,0q�6T   $	��Top=�6h   $	��573��6�   $��38��6�   ���	#FF29863E
�������$��14(�6�   $��IRANSans)�6�   $��Oblique$�6�   $��Expanded&�6�   $
��Bold"�6  {�.  69  �� 5   
   -   5         ��Name$ 
label_Copy��5      $#��شماره دانشجویی :��6$   $��8,10,0,0q�6?   $	��Top=�6Q   $	��105��6i   $��IRANSans)�6u   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5         ��Name$ 	txtNumber��5      $
��Left=�6%   $��26��6@   $��
113,14,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��146��6�   $��Stretch=�6�   �� 5   
   -   5        $ label_Copy2��5      $��نام درس :��6%   $��	37,89,0,0q�69   $	��Top=�6L   $��68��6d   $��IRANSans)�6o   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   �� 5   
   -   5         ��Name$ 	cmbLesson��5      $
��Left=�6&   $��
105,89,0,0q�6A   $	��Top=�6U   $	��177��6m   $��30��6y   {�.  6�   �� 5   
   $��اطلاعات درس��6   $
��Left=�6(   $	��165��6C   $��8,57,0,0q�6P   $	��Top=�6b   $	��573��6z   ���	#FFEA0000$
��Bold"�6�   �� 5   
   -   5        $ lblNameOstad��5      $��نام استاد��6&   $��129,140,0,0q�6:   $	��Top=�6O   $	��434��6g   $��IRANSans)�6s   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   ���	#FF4FAABF6�   �� 5   
   -   5        $ 	btnSearch��5      $��
جستجو��6$   $
��Left=�64   $��	264,7,0,0q�6O   $	��Top=�6b   $��64��6z   $��35��6�   ���	#FF293B86
�������$��14(�6�   $��IRANSans)�6�   $��Oblique$�6�   $��Expanded&�6�   $
��Bold"�6
  6  �� 5   
   -   5        $ lblNameStud��5      $��نام دانشجو��6%   $��
333,10,0,0q�6:   $	��Top=�6N   $	��146��6f   $��IRANSans)�6r   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   ���	#FF4FAABF6�   �� 5   
   -	   5        $ lblField��5      $��رشته دانشجو��6"   $��
484,10,0,0q�68   $	��Top=�6L   $��79��6d   $��IRANSans)�6o   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   ���	#FF4FAABF6�   �� 5   
   -
   5        $ 
lblShOstad��5      $��شناسه استاد��6$   $��
35,140,0,0q�6:   $	��Top=�6N   $��89��6f   $��IRANSans)�6q   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   ���	#FF4FAABF$��Center=�6�   �� 5   
   -   5        $ 
lblShClass��5      $��شناسه کلاس ��6$   $��
35,175,0,0q�6:   $	��Top=�6N   $��89��6f   $��IRANSans)�6q   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   ���	#FF4FAABF$��Center=�6�   �� 5   
   -   5        $ lblNameClass��5      $��نام کلاس��6&   $��129,175,0,0q�69   $	��Top=�6N   $	��152��6f   $��IRANSans)�6r   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   ���	#FF4FAABF6�   �� 5   
   -   5        $ lblDate��5      $��تاریخ برگزاری��6!   $��286,175,0,0q�69   $	��Top=�6N   $	��120��6f   $��IRANSans)�6r   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   ���	#FF4FAABF$��Center=�6�   �� 5   
   -   5        $ lblTime��5      $��ساعت برگزاری��6!   $��411,175,0,0q�68   $	��Top=�6M   $	��152��6e   $��IRANSans)�6q   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   ���	#FF4FAABF$��Center=�6�   �� 5   
   -   5        $ label_Copy10��5      $��تعداد واحد :��6&   $��
287,89,0,0q�6=   $	��Top=�6Q   $��89��6i   $��IRANSans)�6t   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   ���	#FF4FAABF$��Center=�6�   �� 5   
   -   5        $ lblVahed��5      $��0��6"   $��
381,89,0,0q�6.   $	��Top=�6B   $��54��6Z   $��IRANSans)�6e   $��13(�6{   $��RightToLeft=�6�   $
��Left=�6�   ���	#FF4FAABF$��Center=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $	��198��6@   $��
10,270,0,0q�6M   $	��Top=�6a   $	��574��6y   6�   �� 5   
   -   5        $ btnDell��5      $��حذف واحد��6"   $
��Left=�65   $��
10,473,0,0q�6P   $	��Top=�6d   $	��574��6|   $��38��6�   ���	#FFB63939���	#FF861414
�������$��14(�6�   $��IRANSans)�6�   6�   �� 5   
   -   5        $ 
lblFieldId��5      $��0��6$   $��
568,10,0,0q�60   $	��Top=�6D   $��22��6\   $��IRANSans)�6g   $��13(�6}   $��RightToLeft=�6�   $
��Left=�6�   ���	#FF4FAABF$��Center=�6�   �� 5   
   -   5        $ lblVahed_Copy��5      $��معدل��6'   $��
440,89,0,0q�66   $	��Top=�6J   $��39��6b   $��IRANSans)�6m   $��13(�6�   $��RightToLeft=�6�   $
��Left=�6�   ���	#FFE0978B$��Center=�6�   �� 5   
   -   5        $ lblAve��5      $��0��6    $��
484,89,0,0q�6,   $	��Top=�6@   $��79��6X   $��IRANSans)�6c   $��13(�6y   $��RightToLeft=�6�   $
��Left=�6�   ���	#FFE0978B$��Center=�6�   5!      5"      