   M S B A M L   `   `   `  ����W  SP04WeatherForecastAPI.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:P04WeatherForecastAPI.ClientP04WeatherForecastAPI.Client  5   	   a5clr-namespace:P04WeatherForecastAPI.Client.Converters'P04WeatherForecastAPI.Client.Converters  5   	   -    'P04WeatherForecastAPI.Client.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:P04WeatherForecastAPI.Client     5   	   L
converters5clr-namespace:P04WeatherForecastAPI.Client.Converters     5   	     � Title$  
MainWindow��5	   	   $	��500��6   $	��750��6)    � 	Resources 5
         boolToVisConvK  EP04WeatherForecastAPI.Client.Converters.TemperatureToDisplayConverter  tmpToDispConvI  CP04WeatherForecastAPI.Client.Converters.NeighborsToDisplayConverter  neighborsToDispConvH  BP04WeatherForecastAPI.Client.Converters.TimeZoneToDisplayConverter  timeZoneToDispConvS  MP04WeatherForecastAPI.Client.Converters.GeoPositionPropertyToDisplayConverter ! geoPositionPropertyToDispConvD  >P04WeatherForecastAPI.Client.Converters.DateToDisplayConverter  dateToDispConv  mainButtonStyle �� 
TargetType �� Property �� Value  mainLabelStyle��%5  &	        &	      &	 &     &	 9     &	 L     &	 _     &	 r     &	 O    �� 5   
   6@     5   
   6K     5   
   6O     5   
   6M     5   
   6c     5   
   6E   �� 5   
   " ��6(   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ 10q�6(   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 ��ح�6+   �� 5       � ��
 ��  �6+   5      �� 5   
   " ��6'   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ Center=�64   �� 5       � ��
 �  ��6+   5      5      .��5;      ]� .+�5<   
   �� $
��Auto=�6   .��5=      ��  �� Orientation$ Vertical=�6   .+�5?      �� $ 
Horizontal=�6%   $��Center=�6>   .+�5A      �� $	��150��6)   .+�5B   "   �� $��City:��6(   6;   �� 5C   "   -   5         ��Name$ txtCity��5C   *   6=   �� 5D   "   -   5         ��Name$ 	btnSearch��5D   )   $��Search��6<   ��6M   �� *LoadCitiesCommand+��6s   �� *Text+ �� ElementName$ txtCity��6�   �� 5E   "   -   5        	 ��Name$	 lbData��5E   *   
 �� DisplayMemberPath$
 LocalizedName��6   ��6:   �� *Cities+ �� SelectedItem 6Y   �� *SelectedCity+6�   5F      �� 5G      $	��150��6)   5H      �� 5J      .+�5K   "   �� $��Center=�6(   $��
City info:��6E   6\   �� 5M   "   $
��Left=�6(   $��Name:��6C   6U   �� 5N   "   -   5         ��Name$ lblCityName��5N   (   $��Center=�6=   ��6Z   �� *SelectedCity.LocalizedName+6�   �� 5P   "   $
��Left=�6(   $��
Time zone:��6C   6Z   �� 5Q   "   -   5        $ lblTimeZoneValue��5Q   (   $��Center=�6B   ��6_   �� *TimeZoneView+ �� 	Converter# [ 6�   �� 5S   "   $
��Left=�6(   $��Administrative area:��6C   6d   �� 5T   "   -   5        $  lblAdministrativeAreaValue��5T   (   $��Center=�6L   ��6i   �� *&$AdministrativeAreaView.LocalizedName+6�   �� 5V   "   $
��Left=�6(   $��
Neighbors:��6C   6Z   �� 5W   "   -   5        $ lblNeighborsValue��5W   (   $��Center=�6C   ��6`   �� *NeighborsView.Neighbors+# [ 6�   �� 5Y   "   $
��Left=�6(   $��Geoposition:��6C   6\   �� 5Z   "   $ 
Horizontal=�6-   $��Center=�6F   .+�5[   &   �� $
��Left=�6,   $��	Latitude:��6G   6]   �� 5\   &   -   5        $! lblGeoPositionLatitudeValue��5\   ,   $
��Left=�6Q   ��6l   �� *GeoPositionView.Latitude+# [ 6�   5]   #   �� 5^   "   $ 
Horizontal=�6-   $��Center=�6F   .+�5_   &   �� $
��Left=�6,   $��
Longitude:��6G   6^   �� 5`   &   -	   5        $" lblGeoPositionLongitudeValue��5`   ,   $
��Left=�6R   ��6m   �� *GeoPositionView.Longitude+# [ 6�   5a   #   5b      5c      �� 5e      $��Center=�6%   $ Vertical=�6B   .+�5f      �� $��Center=�6)   .+�5g   "   �� $��Center=�6(   $��Current temperature:��6E   6f   �� 5h   "   -
   5        $ lblTemperatureValue��5h   (   $��Center=�6E   ��6b   �� * WeatherView.CurrentTemperature+# [ 6�   �� 5k   "   $��Center=�6(   $��Five days forecast:��6E   6e   �� 5l   "   
���   �$��1q�6=   $��Center=�6Q   ._�5m   &   �  � RowDefinitions 5n   *   �� 5o   .   $
��Auto �6<   �� 5p   .   $
��Auto �6<   �� 5q   .   $
��Auto �6<    � ColumnDefinitions 5t   *   �� 5u   .   $	��120 �6?   �� 5v   .   $��80 �6?   �� 5w   .   $��80 �6?   �� 5x   .   $��80 �6?   �� 5y   .   $��80 �6?   �� 5z   .   $��80 �6?   .+�5~   *   �� $��0��61   $��0��6>   
���   �$��1q�6b   ._�5   .   �� $��Center=�64   $	��Day��6Q   5�   +   �� 5�   *   $��0��61   $��1��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $* $lbl5DaysDailyForecast1stDayDateValue��5�   4   $��Center=�6b   ��6   �� *-+ManyDaysForecastView.DailyForecasts[0].Date+# [ 5�   +   �� 5�   *   $��0��61   $��2��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $* $lbl5DaysDailyForecast2ndDayDateValue��5�   4   $��Center=�6b   ��6   �� *-+ManyDaysForecastView.DailyForecasts[1].Date+# [ 5�   +   �� 5�   *   $��0��61   $��3��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $* $lbl5DaysDailyForecast3rdDayDateValue��5�   4   $��Center=�6b   ��6   �� *-+ManyDaysForecastView.DailyForecasts[2].Date+# [ 5�   +   �� 5�   *   $��0��61   $��4��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $* $lbl5DaysDailyForecast4thDayDateValue��5�   4   $��Center=�6b   ��6   �� *-+ManyDaysForecastView.DailyForecasts[3].Date+# [ 5�   +   �� 5�   *   $��0��61   $��5��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $* $lbl5DaysDailyForecast5thDayDateValue��5�   4   $��Center=�6b   ��6   �� *-+ManyDaysForecastView.DailyForecasts[4].Date+# [ 5�   +   �� 5�   *   $��1��61   $��0��6>   
���   �$��1q�6b   ._�5�   .   �� $��Center=�64   $��Minimum temp.��6Q   5�   +   �� 5�   *   $��1��61   $��1��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $- 'lbl5DaysDailyForecast1stDayMinTempValue��5�   4   $��Center=�6e   ��6�   �� *B@ManyDaysForecastView.DailyForecasts[0].Temperature.Minimum.Value+# [ 5�   +   �� 5�   *   $��1��61   $��2��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $- 'lbl5DaysDailyForecast2ndDayMinTempValue��5�   4   $��Center=�6e   ��6�   �� *B@ManyDaysForecastView.DailyForecasts[1].Temperature.Minimum.Value+# [ 5�   +   �� 5�   *   $��1��61   $��3��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $- 'lbl5DaysDailyForecast3rdDayMinTempValue��5�   4   $��Center=�6e   ��6�   �� *B@ManyDaysForecastView.DailyForecasts[2].Temperature.Minimum.Value+# [ 5�   +   �� 5�   *   $��1��61   $��4��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $- 'lbl5DaysDailyForecast4thDayMinTempValue��5�   4   $��Center=�6e   ��6�   �� *B@ManyDaysForecastView.DailyForecasts[3].Temperature.Minimum.Value+# [ 5�   +   �� 5�   *   $��1��61   $��5��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $- 'lbl5DaysDailyForecast5thDayMinTempValue��5�   4   $��Center=�6e   ��6�   �� *B@ManyDaysForecastView.DailyForecasts[4].Temperature.Minimum.Value+# [ 5�   +   �� 5�   *   $��2��61   $��0��6>   
���   �$��1q�6b   ._�5�   .   �� $��Center=�64   $��Maximum temp.��6Q   5�   +   �� 5�   *   $��2��61   $��1��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $- 'lbl5DaysDailyForecast1stDayMaxTempValue��5�   4   $��Center=�6e   ��6�   �� *B@ManyDaysForecastView.DailyForecasts[0].Temperature.Maximum.Value+# [ 5�   +   �� 5�   *   $��2��61   $��2��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $- 'lbl5DaysDailyForecast2ndDayMaxTempValue��5�   4   $��Center=�6e   ��6�   �� *B@ManyDaysForecastView.DailyForecasts[1].Temperature.Maximum.Value+# [ 5�   +   �� 5�   *   $��2��61   $��3��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $- 'lbl5DaysDailyForecast3rdDayMaxTempValue��5�   4   $��Center=�6e   ��6�   �� *B@ManyDaysForecastView.DailyForecasts[2].Temperature.Maximum.Value+# [ 5�   +   �� 5�   *   $��2��61   $��4��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $- 'lbl5DaysDailyForecast4thDayMaxTempValue��5�   4   $��Center=�6e   ��6�   �� *B@ManyDaysForecastView.DailyForecasts[3].Temperature.Maximum.Value+# [ 5�   +   �� 5�   *   $��2��61   $��5��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $- 'lbl5DaysDailyForecast5thDayMaxTempValue��5�   4   $��Center=�6e   ��6�   �� *B@ManyDaysForecastView.DailyForecasts[4].Temperature.Maximum.Value+# [ 5�   +   5�   '   5�   #   �� 5�   "   $��Center=�6(   $��Six hours forecast:��6E   6e   �� 5�   "   
���   �$��1q�6=   ._�5�   &   �  5�   *   �� 5�   .   $
��Auto �6<   �� 5�   .   $
��Auto �6<    5�   *   �� 5�   .   $	��120 �6?   �� 5�   .   $��80 �6?   �� 5�   .   $��80 �6?   �� 5�   .   $��80 �6?   �� 5�   .   $��80 �6?   �� 5�   .   $��80 �6?   �� 5�   .   $��80 �6?   .+�5�   *   �� $��0��61   $��0��6>   
���   �$��1q�6b   ._�5�   .   �� $��Center=�64   $
��Hour��6Q   5�   +   �� 5�   *   $��0��61   $��1��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $) #lbl6HoursHourlyForecast1stHourValue��5�   4   $��Center=�6a   ��6~   �� *31ManyHoursForecastView.HourlyForecasts[0].DateTime+# [ 5�   +   �� 5�   *   $��0��61   $��2��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $) #lbl6HoursHourlyForecast2ndHourValue��5�   4   $��Center=�6a   ��6~   �� *31ManyHoursForecastView.HourlyForecasts[1].DateTime+# [ 5�   +   �� 5�   *   $��0��61   $��3��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $) #lbl6HoursHourlyForecast3rdHourValue��5�   4   $��Center=�6a   ��6~   �� *31ManyHoursForecastView.HourlyForecasts[2].DateTime+# [ 5�   +   �� 5�   *   $��0��61   $��4��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $) #lbl6HoursHourlyForecast4thHourValue��5�   4   $��Center=�6a   ��6~   �� *31ManyHoursForecastView.HourlyForecasts[3].DateTime+# [ 5�   +   �� 5�   *   $��0��61   $��5��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $) #lbl6HoursHourlyForecast5thHourValue��5�   4   $��Center=�6a   ��6~   �� *31ManyHoursForecastView.HourlyForecasts[4].DateTime+# [ 5�   +   �� 5�   *   $��0��61   $��6��6>   
���   �$��1q�6b   ._�5�   .   �� -   5        $) #lbl6HoursHourlyForecast6thHourValue��5�   4   $��Center=�6a   ��6~   �� *31ManyHoursForecastView.HourlyForecasts[5].DateTime+# [ 5�   +   �� 5�   *   $��1��61   $��0��6>   
���   �$��1q�6b   ._�5�   .   �� $��Center=�64   $��Temp.��6Q   5�   +   �� 5�   *   $��1��61   $��1��6>   
���   �$��1q�6b   ._�5�   .   �� -    5        $- 'lbl6HoursHourlyForecast1stHourTempValue��5�   4   $��Center=�6e   ��6�   �� *<:ManyHoursForecastView.HourlyForecasts[0].Temperature.Value+# [ 5�   +   �� 5�   *   $��1��61   $��2��6>   
���   �$��1q�6b   ._�5�   .   �� -!   5        $- 'lbl6HoursHourlyForecast2ndHourTempValue��5�   4   $��Center=�6e   ��6�   �� *<:ManyHoursForecastView.HourlyForecasts[1].Temperature.Value+# [ 5�   +   �� 5�   *   $��1��61   $��3��6>   
���   �$��1q�6b   ._�5�   .   �� -"   5        $- 'lbl6HoursHourlyForecast3rdHourTempValue��5�   4   $��Center=�6e   ��6�   �� *<:ManyHoursForecastView.HourlyForecasts[2].Temperature.Value+# [ 5�   +   �� 5�   *   $��1��61   $��4��6>   
���   �$��1q�6b   ._�5�   .   �� -#   5        $- 'lbl6HoursHourlyForecast4thHourTempValue��5�   4   $��Center=�6e   ��6�   �� *<:ManyHoursForecastView.HourlyForecasts[3].Temperature.Value+# [ 5�   +   �� 5�   *   $��1��61   $��5��6>   
���   �$��1q�6b   ._�5�   .   �� -$   5        $- 'lbl6HoursHourlyForecast5thHourTempValue��5�   4   $��Center=�6e   ��6�   �� *<:ManyHoursForecastView.HourlyForecasts[4].Temperature.Value+# [ 5�   +   �� 5�   *   $��1��61   $��6��6>   
���   �$��1q�6b   ._�5�   .   �� -%   5        $- 'lbl6HoursHourlyForecast6thHourTempValue��5�   4   $��Center=�6e   ��6�   �� *<:ManyHoursForecastView.HourlyForecasts[5].Temperature.Value+# [ 5�   +   5�   '   5�   #   5�      5�      �� 5�      $��50��6%   5�      5      5     5     5     