   M S B A M L   `   `   `  ����C  ?RankGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:RankGameRankGame  5   	       RankGame.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:RankGame     5   	   e aInfragisticsWPF4.v10.3, Version=10.3.20103.1003, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb/	igWindowshttp://infragistics.com/Windows  5   	   -   5          �Name$
  Main��5   ;    � Title$ 
MainWindow��5	   	   $
��1080��6   $
��1920��6*    � 
ResizeMode$ NoResize=�67    � WindowStyle$
 None=�6M   $
��Left=�6`   $	��Top=�6{    � WindowState$ 	Maximized=�6�   ��6�   Z� ��6�   Z� .��5
      �� -   5         ��Name$ CNV_MainCanvas��5
      $
��Left=�6%   $
��1070��6@   $��0,10,0,0q�6N   $	��Top=�6`   $
��1910��6x   ��5   
   �� 5       �� ImageSource$ Image/BackGround.png��6   .+�5   
   �� -   5         ��Name$ 	IMG_Title��5      $	��332��6#    �� Left$	 220��60   
	 �� Top$		 154��6B   $	��688��6S   $��Image/Logo.PNG��6_   $
��Fill=�6w   
 J� OpacityMask
 5      �� 5      $ Image/Title.PNG��6   5      �� 5   
   -   5         ��Name$ 	Btn_Start��5      $�� ��6$   $	 360��6/   $		 568��6A   $	��348��6R   $	��130��6^    �� 	ClickMode$ Press=�6k   
�������
 5      �� 5      $ Image/Start.png��6   ��5      �� 5      $ Image/Start.png��6   5      �� 5   
   -   5        $ Btn_Exit��5      $�� ��6#   $	 360��6.   $		 826��6@   $	��348��6Q   $	��130��6]   $ Press=�6j   
���������5      �� 5      $ Image/Exit.png��6   
 5      �� 5       $ Image/Exit.png��6   5"      �� 5#   
   -   5         ��Name$ Grb_MessageBox��5#      $��GroupBox��6+   $
 1140��6=   $	 65��6P   $	��943��6`   $	��720��6m   ��5$      �� 5%       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5&      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5'      $ White��6#   $ 1Q�61   5(      .��5*      �� -   5         ��Name$ TB_MessageBox��5*       �� TextWrapping$
 Wrap=�6-   $��-6,54,-6,-12q�6A   $��Arial Black)�6W   $��25(�6p   $
��Bold"�6~   5+      �� 5,   
   -   5        $ IMG_GameState��5,      $��74��6'   $
 1118��63   $	 69��6F   $	��762��6V   $��Image/GameState.png��6b   $
��Fill=�6   
 5-      �� 5.      $ Image/GameState.png��6   50      �� 51   
   -	   5        $ 
Btn_Option��51      $�� ��6%   $	 360��60   $		 696��6B   $	��348��6S   $	��130��6_   $ Press=�6l   
�������
 52      �� 53      $ Image/Option.png��6   ��55      �� 56      $ Image/Option.png��6   58      59      5:      