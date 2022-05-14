﻿using BumbleBikesLibrary;

namespace DecoratorExample;

public class DocumentedBicycle : IBicycle
{
    private IBicycle _undecoratedBicycle;
    private IDocumentor _documentor;
    
    public string ModelName
    {
        get => _undecoratedBicycle.ModelName;
        set => _undecoratedBicycle.ModelName = value;
    }
    public int Year => _undecoratedBicycle.Year;
    public string SerialNumber => _undecoratedBicycle.SerialNumber;
    public BicycleGeometries Geometry
    {
        get => _undecoratedBicycle.Geometry;
        set => _undecoratedBicycle.Geometry = value;
    }
    public BicyclePaintColors Color
    {
        get => _undecoratedBicycle.Color; 
        set => _undecoratedBicycle.Color = value; 
    }
    public SuspensionTypes Suspension { 
        get => _undecoratedBicycle.Suspension;
        set => _undecoratedBicycle.Suspension = value;
    }
    public ManufacturingStatus BuildStatus { 
        get => _undecoratedBicycle.BuildStatus;
        set => _undecoratedBicycle.BuildStatus = value;
    }
    
    public void Build()
    {
        _undecoratedBicycle.Build();
        _documentor.PrintManual();
    }
}