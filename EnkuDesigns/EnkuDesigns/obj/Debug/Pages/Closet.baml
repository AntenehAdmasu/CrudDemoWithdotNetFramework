   M S B A M L   `   `   `  ����F  BEnkuDesigns, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EnkuDesigns.PagesEnkuDesigns.Pages  5      )clr-namespace:EnkuDesignsEnkuDesigns  5          EnkuDesigns.Pages.Closet   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:EnkuDesigns.Pages     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      +enkudesignsclr-namespace:EnkuDesigns  5      .��5   
   �� $��0,0,0,-46.4q�5      
�������  J� RenderTransformOrigin$	  0,0&�5      .+�5      �� $��
45,20,0,10q�5      $��Center=�5      $��25(�5      Closet5      �� 5      $��
45,0,10,10q�6   �� 5       �� Orientation$ 
Horizontal=�5      .+�5      #  MaterialDesignThemes.Wpf.Card  $	��250��5      $��40,8,2,2q�5      $
��Left=�5      .��5      �� .+�5       �  � RowDefinitions 5!      �� 5"   "   $	��140 �60   �� 5#   "   $��* �60   .+�5&      �� -   5         ��Name$ dresspicture��5(      $	��140��5'      $��../Resource/closet.png��5)      $��UniformToFill=�5*      �� 5,      $��1��6)   $��8,8,8,0q�66   .+�5-   "   �� -   5         ��Name$ title��5.   !   $��20(�5/   !    %  !MaterialDesignSubheadingTextBlock#��[  50   !   	ADD DRESS52   #   �� 53   "   -   5         ��Name$ 	dresscode��54   !   $	��5,5q�55   !   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Dress Code��56   !    % !MaterialDesignFloatingHintTextBox#��[ 57   !   �� 58   "   -   5        $ price��59   !   $	��5,5q�5:   !   $ Price��5;   !   #��[ 5<   !   �� 5=      -   5        $ Amount��5>   !   $	��5,0q�5?   !   $ Amount��5@   !   #��[ 5A   !   �� 5B      -   5        $ Description��5C   !    �� AcceptsReturn . $	��5,5q�5E   !   #��[ 5F   !   $ Description��5G   !   �� 5H      $ 
Horizontal=�6)   .+�5I   "   �� -   5        $ ImageLocationTextBox��5I   5   $��5q�6*    �� 
IsReadOnly . $ Select Image��5J   %   #��[ 5K   %   $	��168��6`   �� 5L   "   -   5        	 ��Name$	 
filechoose��5M   !    # MaterialDesignRaisedLightButton#��[ 5O   !   $
��Left=�5P   !   $��5q�5Q   !   
����������#5C6BC0
 � ToolTip$
 Choose Dress Image��5T   !   $��44��6>   $��0q�6I   .��5U   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Image=�6>   $��22��6K   $��22��6V   5V   #   5W      �� 5Y   "   -	   5        $��0,15,0,8q�5Z   !   ���#DDD  MaterialDesignFlatButton#��[ 5]   !   .��6S   	ADD DRESS5_   #   5`      5a      5b      5c      � 5e      $
��1000��6   $	��700��6$   $��
40 0 0 30 q�61   .+�5f      �� -
   5         ��Name$ 
Thelistbox��5f       � IsSharedSizeScope . ��. ��5g      �� 5h      .R�5i   "   � $
��0 10q�6'    � ColumnDefinitions 5j   &   �� 5k   *   $
��Auto �6;    z� SharedSizeGroup$ 
ColumnSize��6H   .+�5m   &   &    EnkuDesigns.DressCardUserControl  &    EnkuDesigns.DressCardUserControl   MouseDoubleClick DressClicked6G   5o   #   5p      ��5s      �� 5t      .R�5u   "   � $
��40 0q�6,   6<   5v      5x      5z      5{      5}      5~      