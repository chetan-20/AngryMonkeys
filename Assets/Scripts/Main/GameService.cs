using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ServiceLocator.Utilities;
using ServiceLocator.Player;
using ServiceLocator.Sound;
using ServiceLocator.UI;
using ServiceLocator.Wave;
using ServiceLocator.Map;
using ServiceLocator.Events;
public class GameService : GenericMonoSingleton<GameService>
{
    [SerializeField] private SoundService soundService;
    [SerializeField] private PlayerScriptableObject playerScriptableObject;
    [SerializeField] private SoundScriptableObject soundScriptableObject;
    [SerializeField] private AudioSource audioEffects;
    [SerializeField] private AudioSource backgroundMusic;
    [SerializeField] private UIService uiservice;
    [SerializeField] private WaveScriptableObject waveScriptableObject;
    [SerializeField] private MapScriptableObject mapScriptableObject;
    public PlayerService playerserivce { get; private set; }
    public SoundService soundservice { get; private set; }
    public UIService UIService => uiservice;
    public WaveService waveservice { get; private set; }
    public MapService mapservice { get; private set; }
    public EventService EventService { get; private set; }
   
    
    private void Start()
    { 
        EventService = new EventService();
        playerserivce = new PlayerService(playerScriptableObject);
        soundservice = new SoundService(soundScriptableObject,audioEffects,backgroundMusic);
        waveservice = new WaveService(waveScriptableObject);
        mapservice = new MapService(mapScriptableObject);
    }

    private void Update()
    {
        playerserivce.Update();
    }
}
