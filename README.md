

## Learn LiveCharts2: Create Demo

### NuGet Packages Required in WPF

To use LiveCharts2 in a WPF project, you will need the following NuGet packages:

| NuGet Package                                   | Description                             |
| ------------------------------------------------ | --------------------------------------- |
| [LiveCharts.Wpf](https://www.nuget.org/packages/LiveCharts.Wpf/) | Provides WPF specific implementations for LiveCharts2. |
| [LiveChartsCore.SkiaSharpView.WPF](https://www.nuget.org/packages/LiveChartsCore.SkiaSharpView.WPF/) | Integrates SkiaSharp with LiveCharts2 for WPF, enabling more rendering options. |

### UserControl 1: Using LiveCharts.Wpf to Show Static Data

This section demonstrates how to use `LiveCharts.Wpf` to display static data in a `UserControl`.

1. **Create a new WPF UserControl**:
   - Design your `UserControl` in XAML, adding a `CartesianChart` control where you want to display the chart.

2. **Add the NuGet package**:
   - Install the `LiveCharts.Wpf` package via NuGet Package Manager.

3. **Populate the chart with static data**:
   - In your code-behind, create a `SeriesCollection` and add `LineSeries` or other series types with static data.

```csharp
// Example of adding static data to a chart Add the series to the chart
 SeriesCollection = new SeriesCollection
 {
    
     new LineSeries
     {
         Title = "曲线 1",
         Values = new ChartValues<double> { 3, 7, 2, 5, 6 },
         Fill = new SolidColorBrush(Colors.LightBlue), 
         PointGeometry = null 
     },
     new LineSeries
     {
         Title = "曲线 2",
         Values = new ChartValues<double> { 4, 2, 5, 6, 3 },
         Fill = new SolidColorBrush(Colors.LightCoral), 
         PointGeometry = null 
     }
     
 };
 Labels = new string[] { "一", "二", "三", "四", "五" };
```

### UserControl 2: Using LiveChartsCore.SkiaSharpView.WPF to Show Dynamic Data

This section shows how to use `LiveChartsCore.SkiaSharpView.WPF` to display dynamic data in a `UserControl`.

1. **Create a new WPF UserControl**:
   - Design your `UserControl` in XAML, adding a `CartesianChart` control where you want to display the chart.

2. **Add the NuGet package**:
   - Install the `LiveChartsCore.SkiaSharpView.WPF` package via NuGet Package Manager.

3. **Populate the chart with dynamic data**:
   - In your code-behind, create a dynamic data model and bind it to the chart.

```csharp
// Example of adding dynamic data to a chart Simulate dynamic data updates
_values.Add(new DateTimePoint(DateTime.Now, _random.Next(0, 10)));
if (_values.Count > 250) _values.RemoveAt(0);
_values2.Add(new DateTimePoint(DateTime.Now, _random.Next(0, 10)));
if (_values2.Count > 250) _values2.RemoveAt(0);

// Add the series to the chart
 Series = [
     new LineSeries<DateTimePoint>
 {
     Values = _values,
     Fill = null,
     GeometryFill = null,
     GeometryStroke = null,
     Name="1"
 },new LineSeries<DateTimePoint>
 {
     Values = _values2,
     Fill = null,
     GeometryFill = null,
     GeometryStroke = null,
     Name="2"
 }
 ];
```

### See the Official Content for More Details

For more information and detailed guidance, visit the official [LiveCharts2 GitHub repository](https://github.com/beto-rodriguez/LiveCharts2). The repository contains samples, documentation, and additional resources to help you get started with LiveCharts2.

---
