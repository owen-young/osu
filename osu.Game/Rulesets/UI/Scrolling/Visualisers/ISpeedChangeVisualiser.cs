﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

namespace osu.Game.Rulesets.UI.Scrolling.Visualisers
{
    public interface ISpeedChangeVisualiser
    {
        double GetDisplayStartTime(double time);

        float GetLength(double startTime, double endTime);

        float PositionAt(double time, double currentTime);
    }
}
