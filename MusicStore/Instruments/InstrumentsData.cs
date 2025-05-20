using System.Runtime.Serialization;

namespace MusicStore.Instruments;

[DataContract]
public class InstrumentsData
{
    [DataMember]
    public List<MusicalInstrument> InstrumentsList;
    
    private readonly FlowLayoutPanel _flowLayoutPanel;
    private readonly List<List<MusicalInstrument>> _changeHistory;
    private int _index;
    
    public MusicalInstrument this[int index]
    {
        get => InstrumentsList[index];
        set => InstrumentsList[index] = value;
    }

    public InstrumentsData(FlowLayoutPanel flowLayoutPanel)
    {
        _flowLayoutPanel = flowLayoutPanel;
        _changeHistory = new List<List<MusicalInstrument>>() { new List<MusicalInstrument>() };
        InstrumentsList = new List<MusicalInstrument>();
        _index = 0;
    }

    public void AddInstrument(MusicalInstrument instrument)
    {
        InstrumentsList.Add(instrument);
        _flowLayoutPanel.Controls.Add(instrument.Visualize());
        UpdateHistory();
    }

    public void RemoveInstrument(MusicalInstrument instrument)
    {
        InstrumentsList.Remove(instrument);
        UpdateHistory();
        UpdateView();
    }
    public void UpdateHistory()
    {
        _index++;
        var copy = new List<MusicalInstrument>();
        foreach (var instrument in InstrumentsList)
        {
            copy.Add(instrument.DeepCopy());
        }
        _changeHistory.Insert(_index, copy);
        _changeHistory.RemoveRange(_index + 1, _changeHistory.Count - _index - 1);
    }
    public void UpdateView()
    {
        _flowLayoutPanel.Controls.Clear();
        foreach (var instrument in InstrumentsList)
        {
            _flowLayoutPanel.Controls.Add(instrument.Visualize());
        }
    }

    public void Undo()
    {
        if (_index > 0)
        {
            --_index;
            InstrumentsList = new List<MusicalInstrument>(_changeHistory[_index]);
            UpdateView();
        }    
    }

    public void Redo()
    {
        if (_index < _changeHistory.Count - 1)
        {
            ++_index;
            InstrumentsList = new List<MusicalInstrument>(_changeHistory[_index]);
            UpdateView();
        }
    }
    

}