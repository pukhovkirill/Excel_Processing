   M S B A M L   `   `   `  ���� @  <AppUX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AppUX.Theme.WindowAppUX.Theme.Window  ;"clr-namespace:AppUX.Control.WindowAppUX.Control.Window  R NMicrosoft.Windows.Shell, Version=3.0.1.0, Culture=neutral, PublicKeyToken=nullbFclr-namespace:Microsoft.Windows.Shell;assembly=Microsoft.Windows.ShellMicrosoft.Windows.Shell W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.41.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aaR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   RayeWindowStyle  �� 
TargetType#    AppUX.Theme.Window.RayeWindow �� Property �� Value*  $Microsoft.Windows.Shell.WindowChrome   ResizeBorderThickness   CaptionHeight   CornerRadius   GlassFrameThickness �� 
TargetType � 	Resources  Key	 �Name  	GridStyle
 � RowDefinitions � ColumnDefinitions ��Name   IsHitTestVisibleInChrome �� RelativeSource �� Mode �� AncestorType � Title   BooleanToVisibilityConverter �� 	Converter+   %AppUX.Control.Window.WindowControlBox  Name  ControlStyle   MinimizeBox   MaximizeBox �� Triggers P� Property P� Value �� 
TargetName�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     +window clr-namespace:AppUX.Theme.Window  .control"clr-namespace:AppUX.Control.Window  PshellFclr-namespace:Microsoft.Windows.Shell;assembly=Microsoft.Windows.Shell  %�  &	        7  �� "    .���  � ��$	 300����  �@ WindowChrome   $ 5q�$ 25Q�$ 0��$ 0,0,0,1q���  � �� �� "    ����  BooleanToVisibilityConverter .R�� $
	 Grid��$��0q�#���  
 �� $
��30px ��� $��1* �.+�� $��0�� �� $
��Auto ��� $
��Auto ��� $��1* ��� $
��Auto �.+�� $��0��.+�� $��	10,0,10,0q�$
��Left=�$��Center=�.+��� $ 
HeaderIcon�� . ���� *
HeaderIcon+ �� $ FindAncestor=�"   � $��1��.+��� #��z $
��Left=�$��Center=�y��� *IsHeaderTextVisible+8    �� *FindAncestor+"   � $��2��.+���  . ���� *HeaderContent+ �� *FindAncestor+"   � $��3��.+�  $ WindowControlBox��$	��120��#���   .  �� *MinimizeBox+ �� $ FindAncestor=�"    �� *MaximizeBox+ �� $ FindAncestor=�"   � $��1��.+��� #��z�� P�  �@�WindowState$ 	Maximized=�. ��� $
 Grid�� � ��$ 8q�