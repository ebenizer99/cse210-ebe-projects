using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonusPoints;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetAmount,
        int bonusPoints,
        int amountCompleted = 0)
        : base(name, description, points)
    {
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _targetAmount)
        {
            _amountCompleted++;

            if (_amountCompleted == _targetAmount)
            {
                return _points + _bonusPoints;
            }

            return _points;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;
    }

    public override string GetDetailsString()
    {
        string checkBox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkBox} {_name} ({_description}) -- Completed {_amountCompleted}/{_targetAmount} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetAmount}|{_bonusPoints}|{_amountCompleted}";
    }
}