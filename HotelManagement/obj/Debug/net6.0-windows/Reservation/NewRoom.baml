   M S B A M L   `   `   `  ????J  FHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HotelManagement.ReservationHotelManagement.Reservation  5   	   )    #HotelManagement.Reservation.NewRoom   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:HotelManagement.Reservation     5   	     ? Title$  NewRoom??5   	   $	??450??6   $	??800??6&   .??5	      ? .+?5
   
   ?? -   5         ??Name$ 	nameField??5
       ?? TextWrapping$
 Wrap=?6%   $?? ??69   $??136,105,519,289q?6A   ?? 5   
   $??Назва готелю??6   $
??Left=?6'   $??
131,77,0,0q?6B   $	??Top=?6V   $??91??6n   $??23??6y   ?? 5   
   $??
Номер??6   $
??Left=?6    $??
346,77,0,0q?6;   $	??Top=?6O   ?? 5   
   -   5        $ number??5      $
 Wrap=?6"   $?? ??66   $??352,103,303,291q?6>   ?? 5   
   $#??Кількість вікон??6   $
??Left=?6*   $??136,249,0,0q?6E   $	??Top=?6Z   ?? 5   
   $??
Площа??6   $
??Left=?6    $??352,249,0,0q?6;   $	??Top=?6P   ?? 5   
   -   5        $ windowsAmount??5      $
 Wrap=?6)   $?? ??6=   $??136,280,506,114q?6E    J? RenderTransformOrigin$ 0.477,0.498&?6^   ?? 5   
   $%??Кількість кімнат??6   $
??Left=?6+   $??136,161,0,0q?6F   $	??Top=?6[   ?? 5   
   $#??Кількість місць??6   $
??Left=?6*   $??346,161,0,0q?6E   $	??Top=?6Z   ?? 5   
   -   5        $ roomsAmount??5      $
 Wrap=?6'   $?? ??6;   $??136,196,519,198q?6C   ?? 5   
   -   5        $ 
bedsAmount??5      $
 Wrap=?6&   $?? ??6:   $??352,196,310,198q?6B   ?? 5   
   -   5         ??Name$ 	submitBtn??5      $??Додати номер??6$   $
??Left=?6;   $??35??6V   $??303,365,0,0q?6b   $	??Top=?6w   $	??178??6?   6?   	? 5   
   -   5         	?Name$ addToExisting??5   (    d? 	IsChecked$ falseY?6   $7??1Додати до існуючого готелю??6?   $
??Left=?6d   $??
131,57,0,0q?6   $	??Top=?6?   	? 5   
   -   5        $ addToNew??5   (   $ falseY?6   $1??+Додати до нового готелю??6:   $
??Left=?6\   $??
352,57,0,0q?6w   $	??Top=?6?   ?? 5   
   -	   5        $ square_??5      $
 Wrap=?6#   $?? ??67   $??352,280,310,114q?6?   ?? 5   
   $??Ціна??6   $
??Left=?6   $??520,249,0,0q?6:   $	??Top=?6O   ?? 5   
   -
   5        $ price_??5      $
 Wrap=?6"   $?? ??66   $??520,280,142,114q?6>   ?? 5   
   $??
Зірки??6   $
??Left=?6    $??
550,77,0,0q?6;   $	??Top=?6O   ?? 5   
   -   5        $ stars_??5      $
 Wrap=?6"   $?? ??66   $??550,103,105,291q?6>   5      5      