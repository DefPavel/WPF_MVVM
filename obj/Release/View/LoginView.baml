   M S B A M L   `   `   `  ���� C  ?WPF_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF_MVVMWPF_MVVM  3clr-namespace:WPF_MVVM.HelpersWPF_MVVM.Helpers      WPF_MVVM.LoginView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (localclr-namespace:WPF_MVVM     /pwbxclr-namespace:WPF_MVVM.Helpers     
�������$	��550��$	��280��$��Segoe UI Light)�$��14(�.���   � ColumnDefinitions  �� $��* ��� $
��auto ��� $
��auto ��� $��* � � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* �.+��� $��0��$��1��$��2��$��Center=�$��Application in MMV��$��40(�$��	0 20 0 20q��� $��1��$��1��$ ��Введите логин:��$��5q�$
��Left=��� -    ��Name$ UserName��$��1��$��2��$	��150��$	��320��$��5q��� $��2��$��1��$"��Введите пароль:��$��5q�$
��Left=�G� -    G�Name$ Password��$��2��$��2��$	��150��$	��320��$��5q�'   !WPF_MVVM.Helpers.BoundPasswordBox   BoundPassword �� *
Password+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . �� -   	 ��Name$	 	CheckSave��$��3��$��1��$��2��$��12(�$��_Сохранить?��$��5q�$��Right=��� -   
 ��Name$
 LoginIn��$��1��$��4��$��2��$��Авторизация��$
��10 5q�$��5q�$��Right=��� -    ��Name$ ErrorMessage��$��5��$��1��$��2��
���  ��$��5q�$	��300��$
��Wrap=�$��Center=�y��� *IsErrorVisible+    BooleanToVisibilityConverter �� 	Converter# [   �� FallbackValue$ 	Collapsed��