using System.Collections.Generic;
using UnityEngine;

public class ReadyView : BaseView
{
    [SerializeField] private List<Transform> _slots;
    private ReadyUI _readyUI;
    public int StatChoiceCount => _readyUI.StatChoiceCount;

    private void Awake()
    {
        _readyUI = GetComponent<ReadyUI>();

        BindUI();
    }

    private void FixedUpdate()
    {
        transform.SetSiblingIndex(2);
    }

    public void UpdateChoiceView(List<ChoiceData> tripleChoices)
    {
        foreach (var slot in _slots)
        {
            var views = slot.GetComponentsInChildren<ChoiceView>();
            foreach (var view in views)
            {
                ResourceManager.Instance.Destroy(view.gameObject);
            }
        }

        if (tripleChoices.Count == 0)
        {
            GameEventSystem.Instance.Publish((int)ProcessEvents.ProcessEvent_Engage);
            return;
        }

        int index = 0;
        foreach (var choice in tripleChoices)
        {
            var prefab = ResourceManager.Instance.SpawnFromPath(choice.GetPrefabPath, _slots[index++]);
            var choiceView = prefab.GetComponent<ChoiceView>();

            choiceView.SetupUI(choice);
        }
    }

    public override void BindUI()
    {
    }

    public void DisCountStatChoiceCount()
    {
        _readyUI.DisCountStatChoiceCount();
    }
}