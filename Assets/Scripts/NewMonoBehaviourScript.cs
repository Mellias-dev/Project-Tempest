// === MarchandiseSpawner.cs ===
using System.Collections.Generic;
using UnityEngine;

public class MarchandiseSpawner : MonoBehaviour
{
    [SerializeField] private List<MarchandiseData> _marchandises;
    [SerializeField] private MarchandiseView _viewPrefab;
    [SerializeField] private Transform _container;

    private readonly List<MarchandiseView> _views = new();

    private void Start() => SpawnAll();

    public void SpawnAll()
    {
        ClearAll();

        foreach (var marchandise in _marchandises)
        {
            var model = new MarchandiseModel();
            model.SetCard(marchandise);

            var view = Instantiate(_viewPrefab, _container);
            view.SetCard(model);

            _views.Add(view);
        }
    }

    public void ClearAll()
    {
        foreach (var view in _views)
            Destroy(view.gameObject);

        _views.Clear();
    }
}