﻿using WheelchairProject.WheelchairComponents.Axles;
using WheelchairProject.WheelchairComponents.Casters;

namespace WheelchairProject.WheelchairComponents.Frames;

public abstract class WheelchairFrame : WheelchairComponent
{
    private CasterAssembly _leftCaster;
    private CasterAssembly _rightCaster;
    private Axle _axle;

    public Axle Axle
    {
        get => _axle;
        set
        {
            _axle = value;
            FixComposite();
        }
    }

    public CasterAssembly LeftCaster
    {
        get => _leftCaster;
        set
        {
            _leftCaster = value;
            FixComposite();
        }
    }

    public CasterAssembly RightCaster
    {
        get => _rightCaster;
        set
        {
            _rightCaster = value;
            FixComposite();
        }
    }

    private void FixComposite()
    {
        Subcomponents.Clear();
        Subcomponents.Add(_axle);
        Subcomponents.Add(_leftCaster);
        Subcomponents.Add(_rightCaster);
    }
    
}