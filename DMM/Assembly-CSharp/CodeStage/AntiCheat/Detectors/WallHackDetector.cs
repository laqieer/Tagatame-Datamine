// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.Detectors.WallHackDetector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace CodeStage.AntiCheat.Detectors
{
  [Token(Token = "0x20036BB")]
  [AddComponentMenu("Code Stage/Anti-Cheat Toolkit/WallHack Detector")]
  [HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_wall_hack_detector.html")]
  [DisallowMultipleComponent]
  public class WallHackDetector : ACTkDetectorBase
  {
    [Token(Token = "0x4010103")]
    internal const string ComponentName = "WallHack Detector";
    [Token(Token = "0x4010104")]
    internal const string FinalLogPrefix = "[ACTk] WallHack Detector: ";
    [Token(Token = "0x4010105")]
    private const string ServiceContainerName = "[WH Detector Service]";
    [Token(Token = "0x4010106")]
    private const string WireframeShaderName = "Hidden/ACTk/WallHackTexture";
    [Token(Token = "0x4010107")]
    private const int ShaderTextureSize = 4;
    [Token(Token = "0x4010108")]
    private const int RenderTextureSize = 4;
    [Token(Token = "0x4010109")]
    [FieldOffset(Offset = "0x1C")]
    private readonly Vector3 rigidPlayerVelocity;
    [Token(Token = "0x401010A")]
    [FieldOffset(Offset = "0x0")]
    private static int instancesInScene;
    [Token(Token = "0x401010B")]
    [FieldOffset(Offset = "0x28")]
    private readonly WaitForEndOfFrame waitForEndOfFrame;
    [Token(Token = "0x401010C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [Tooltip("Check for the \"walk through the walls\" kind of cheats made via Rigidbody hacks?")]
    private bool checkRigidbody;
    [Token(Token = "0x401010D")]
    [FieldOffset(Offset = "0x2D")]
    [SerializeField]
    [Tooltip("Check for the \"walk through the walls\" kind of cheats made via Character Controller hacks?")]
    private bool checkController;
    [Token(Token = "0x401010E")]
    [FieldOffset(Offset = "0x2E")]
    [Tooltip("Check for the \"see through the walls\" kind of cheats made via shader or driver hacks (wireframe, color alpha, etc.)?")]
    [SerializeField]
    private bool checkWireframe;
    [Token(Token = "0x401010F")]
    [FieldOffset(Offset = "0x2F")]
    [Tooltip("Check for the \"shoot through the walls\" kind of cheats made via Raycast hacks?")]
    [SerializeField]
    private bool checkRaycast;
    [Token(Token = "0x4010110")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("Delay between Wireframe module checks, from 1 up to 60 secs.")]
    [Range(1f, 60f)]
    public int wireframeDelay;
    [Token(Token = "0x4010111")]
    [FieldOffset(Offset = "0x34")]
    [Tooltip("Delay between Raycast module checks, from 1 up to 60 secs.")]
    [Range(1f, 60f)]
    public int raycastDelay;
    [Token(Token = "0x4010112")]
    [FieldOffset(Offset = "0x38")]
    [Tooltip("World position of the container for service objects within 3x3x3 cube (drawn as red wire cube in scene).")]
    public Vector3 spawnPosition;
    [Token(Token = "0x4010113")]
    [FieldOffset(Offset = "0x44")]
    [Tooltip("Maximum false positives in a row for each detection module before registering a wall hack.")]
    public byte maxFalsePositives;
    [Token(Token = "0x4010114")]
    [FieldOffset(Offset = "0x48")]
    private GameObject serviceContainer;
    [Token(Token = "0x4010115")]
    [FieldOffset(Offset = "0x4C")]
    private GameObject solidWall;
    [Token(Token = "0x4010116")]
    [FieldOffset(Offset = "0x50")]
    private GameObject thinWall;
    [Token(Token = "0x4010117")]
    [FieldOffset(Offset = "0x54")]
    private Camera wfCamera;
    [Token(Token = "0x4010118")]
    [FieldOffset(Offset = "0x58")]
    private MeshRenderer foregroundRenderer;
    [Token(Token = "0x4010119")]
    [FieldOffset(Offset = "0x5C")]
    private MeshRenderer backgroundRenderer;
    [Token(Token = "0x401011A")]
    [FieldOffset(Offset = "0x60")]
    private Color wfColor1;
    [Token(Token = "0x401011B")]
    [FieldOffset(Offset = "0x70")]
    private Color wfColor2;
    [Token(Token = "0x401011C")]
    [FieldOffset(Offset = "0x80")]
    private Shader wfShader;
    [Token(Token = "0x401011D")]
    [FieldOffset(Offset = "0x84")]
    private Material wfMaterial;
    [Token(Token = "0x401011E")]
    [FieldOffset(Offset = "0x88")]
    private Texture2D shaderTexture;
    [Token(Token = "0x401011F")]
    [FieldOffset(Offset = "0x8C")]
    private Texture2D targetTexture;
    [Token(Token = "0x4010120")]
    [FieldOffset(Offset = "0x90")]
    private RenderTexture renderTexture;
    [Token(Token = "0x4010121")]
    [FieldOffset(Offset = "0x94")]
    private int whLayer;
    [Token(Token = "0x4010122")]
    [FieldOffset(Offset = "0x98")]
    private int raycastMask;
    [Token(Token = "0x4010123")]
    [FieldOffset(Offset = "0x9C")]
    private Rigidbody rigidPlayer;
    [Token(Token = "0x4010124")]
    [FieldOffset(Offset = "0xA0")]
    private CharacterController charControllerPlayer;
    [Token(Token = "0x4010125")]
    [FieldOffset(Offset = "0xA4")]
    private float charControllerVelocity;
    [Token(Token = "0x4010126")]
    [FieldOffset(Offset = "0xA8")]
    private byte rigidbodyDetections;
    [Token(Token = "0x4010127")]
    [FieldOffset(Offset = "0xA9")]
    private byte controllerDetections;
    [Token(Token = "0x4010128")]
    [FieldOffset(Offset = "0xAA")]
    private byte wireframeDetections;
    [Token(Token = "0x4010129")]
    [FieldOffset(Offset = "0xAB")]
    private byte raycastDetections;
    [Token(Token = "0x401012A")]
    [FieldOffset(Offset = "0xAC")]
    private bool wireframeDetected;
    [Token(Token = "0x401012B")]
    [FieldOffset(Offset = "0xB0")]
    private readonly RaycastHit[] rayHits;

    [Token(Token = "0x17002384")]
    public bool CheckRigidbody
    {
      [Token(Token = "0x600F773"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F774"), Address(RVA = "0xB79680", Offset = "0xB78480", VA = "0x10B79680")] set
      {
      }
    }

    [Token(Token = "0x17002385")]
    public bool CheckController
    {
      [Token(Token = "0x600F775"), Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F776"), Address(RVA = "0xB79560", Offset = "0xB78360", VA = "0x10B79560")] set
      {
      }
    }

    [Token(Token = "0x17002386")]
    public bool CheckWireframe
    {
      [Token(Token = "0x600F777"), Address(RVA = "0x39CB50", Offset = "0x39B950", VA = "0x1039CB50")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F778"), Address(RVA = "0xB79710", Offset = "0xB78510", VA = "0x10B79710")] set
      {
      }
    }

    [Token(Token = "0x17002387")]
    public bool CheckRaycast
    {
      [Token(Token = "0x600F779"), Address(RVA = "0xAB4EA0", Offset = "0xAB3CA0", VA = "0x10AB4EA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F77A"), Address(RVA = "0xB795F0", Offset = "0xB783F0", VA = "0x10B795F0")] set
      {
      }
    }

    [Token(Token = "0x600F77B")]
    [Address(RVA = "0xB75F00", Offset = "0xB74D00", VA = "0x10B75F00")]
    public static WallHackDetector AddToSceneOrGetExisting() => (WallHackDetector) null;

    [Token(Token = "0x600F77C")]
    [Address(RVA = "0xB77270", Offset = "0xB76070", VA = "0x10B77270")]
    public static void StartDetection()
    {
    }

    [Token(Token = "0x600F77D")]
    [Address(RVA = "0xB773E0", Offset = "0xB761E0", VA = "0x10B773E0")]
    public static void StartDetection(Action callback)
    {
    }

    [Token(Token = "0x600F77E")]
    [Address(RVA = "0xB77210", Offset = "0xB76010", VA = "0x10B77210")]
    public static void StartDetection(Action callback, Vector3 spawnPosition)
    {
    }

    [Token(Token = "0x600F77F")]
    [Address(RVA = "0xB77460", Offset = "0xB76260", VA = "0x10B77460")]
    public static void StartDetection(
      Action callback,
      Vector3 spawnPosition,
      byte maxFalsePositives)
    {
    }

    [Token(Token = "0x600F780")]
    [Address(RVA = "0xB77A50", Offset = "0xB76850", VA = "0x10B77A50")]
    public static void StopDetection()
    {
    }

    [Token(Token = "0x600F781")]
    [Address(RVA = "0xB76280", Offset = "0xB75080", VA = "0x10B76280")]
    public static void Dispose()
    {
    }

    [Token(Token = "0x17002388")]
    public static WallHackDetector Instance
    {
      [Token(Token = "0x600F782"), Address(RVA = "0xB79530", Offset = "0xB78330", VA = "0x10B79530")] get
      {
        return (WallHackDetector) null;
      }
      [Token(Token = "0x600F783"), Address(RVA = "0xB797A0", Offset = "0xB785A0", VA = "0x10B797A0")] private set
      {
      }
    }

    [Token(Token = "0x17002389")]
    private static WallHackDetector GetOrCreateInstance
    {
      [Token(Token = "0x600F784"), Address(RVA = "0xB79390", Offset = "0xB78190", VA = "0x10B79390")] get
      {
        return (WallHackDetector) null;
      }
    }

    [Token(Token = "0x600F785")]
    [Address(RVA = "0xB792A0", Offset = "0xB780A0", VA = "0x10B792A0")]
    private WallHackDetector()
    {
    }

    [Token(Token = "0x600F786")]
    [Address(RVA = "0xB75F10", Offset = "0xB74D10", VA = "0x10B75F10")]
    private void Awake()
    {
    }

    [Token(Token = "0x600F787")]
    [Address(RVA = "0xB76780", Offset = "0xB75580", VA = "0x10B76780", Slot = "4")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600F788")]
    [Address(RVA = "0xB76910", Offset = "0xB75710", VA = "0x10B76910")]
    private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
    {
    }

    [Token(Token = "0x600F789")]
    [Address(RVA = "0xB76340", Offset = "0xB75140", VA = "0x10B76340")]
    private void FixedUpdate()
    {
    }

    [Token(Token = "0x600F78A")]
    [Address(RVA = "0xB79150", Offset = "0xB77F50", VA = "0x10B79150")]
    private void Update()
    {
    }

    [Token(Token = "0x600F78B")]
    [Address(RVA = "0xB77040", Offset = "0xB75E40", VA = "0x10B77040")]
    private void StartDetectionInternal(
      Action callback,
      Vector3 servicePosition,
      byte falsePositivesInRow)
    {
    }

    [Token(Token = "0x600F78C")]
    [Address(RVA = "0xB77010", Offset = "0xB75E10", VA = "0x10B77010", Slot = "12")]
    protected override void StartDetectionAutomatically()
    {
    }

    [Token(Token = "0x600F78D")]
    [Address(RVA = "0xB769C0", Offset = "0xB757C0", VA = "0x10B769C0", Slot = "10")]
    protected override void PauseDetector()
    {
    }

    [Token(Token = "0x600F78E")]
    [Address(RVA = "0xB76A50", Offset = "0xB75850", VA = "0x10B76A50", Slot = "11")]
    protected override bool ResumeDetector() => new bool();

    [Token(Token = "0x600F78F")]
    [Address(RVA = "0xB77A20", Offset = "0xB76820", VA = "0x10B77A20", Slot = "9")]
    protected override void StopDetectionInternal()
    {
    }

    [Token(Token = "0x600F790")]
    [Address(RVA = "0xB761B0", Offset = "0xB74FB0", VA = "0x10B761B0", Slot = "7")]
    protected override void DisposeInternal()
    {
    }

    [Token(Token = "0x600F791")]
    [Address(RVA = "0xB77D90", Offset = "0xB76B90", VA = "0x10B77D90")]
    private void UpdateServiceContainer()
    {
    }

    [Token(Token = "0x600F792")]
    [Address(RVA = "0xB765B0", Offset = "0xB753B0", VA = "0x10B765B0")]
    private IEnumerator InitDetector() => (IEnumerator) null;

    [Token(Token = "0x600F793")]
    [Address(RVA = "0xB77530", Offset = "0xB76330", VA = "0x10B77530")]
    private void StartRigidModule()
    {
    }

    [Token(Token = "0x600F794")]
    [Address(RVA = "0xB76D00", Offset = "0xB75B00", VA = "0x10B76D00")]
    private void StartControllerModule()
    {
    }

    [Token(Token = "0x600F795")]
    [Address(RVA = "0xB77910", Offset = "0xB76710", VA = "0x10B77910")]
    private void StartWireframeModule()
    {
    }

    [Token(Token = "0x600F796")]
    [Address(RVA = "0xB76C50", Offset = "0xB75A50", VA = "0x10B76C50")]
    private void ShootWireframeModule()
    {
    }

    [Token(Token = "0x600F797")]
    [Address(RVA = "0xB76040", Offset = "0xB74E40", VA = "0x10B76040")]
    private IEnumerator CaptureFrame() => (IEnumerator) null;

    [Token(Token = "0x600F798")]
    [Address(RVA = "0xB774A0", Offset = "0xB762A0", VA = "0x10B774A0")]
    private void StartRaycastModule()
    {
    }

    [Token(Token = "0x600F799")]
    [Address(RVA = "0xB76AC0", Offset = "0xB758C0", VA = "0x10B76AC0")]
    private void ShootRaycastModule()
    {
    }

    [Token(Token = "0x600F79A")]
    [Address(RVA = "0xB77B50", Offset = "0xB76950", VA = "0x10B77B50")]
    private void StopRigidModule()
    {
    }

    [Token(Token = "0x600F79B")]
    [Address(RVA = "0xB779A0", Offset = "0xB767A0", VA = "0x10B779A0")]
    private void StopControllerModule()
    {
    }

    [Token(Token = "0x600F79C")]
    [Address(RVA = "0xB77C10", Offset = "0xB76A10", VA = "0x10B77C10")]
    private void StopWireframeModule()
    {
    }

    [Token(Token = "0x600F79D")]
    [Address(RVA = "0xB77B10", Offset = "0xB76910", VA = "0x10B77B10")]
    private void StopRaycastModule()
    {
    }

    [Token(Token = "0x600F79E")]
    [Address(RVA = "0xB76620", Offset = "0xB75420", VA = "0x10B76620")]
    private void InitRigidModule()
    {
    }

    [Token(Token = "0x600F79F")]
    [Address(RVA = "0xB76470", Offset = "0xB75270", VA = "0x10B76470")]
    private void InitControllerModule()
    {
    }

    [Token(Token = "0x600F7A0")]
    [Address(RVA = "0xB77CF0", Offset = "0xB76AF0", VA = "0x10B77CF0")]
    private void UninitRigidModule()
    {
    }

    [Token(Token = "0x600F7A1")]
    [Address(RVA = "0xB77C50", Offset = "0xB76A50", VA = "0x10B77C50")]
    private void UninitControllerModule()
    {
    }

    [Token(Token = "0x600F7A2")]
    [Address(RVA = "0xB76160", Offset = "0xB74F60", VA = "0x10B76160")]
    private bool Detect() => new bool();

    [Token(Token = "0x600F7A3")]
    [Address(RVA = "0xB76420", Offset = "0xB75220", VA = "0x10B76420")]
    private static Color32 GenerateColor() => new Color32();

    [Token(Token = "0x600F7A4")]
    [Address(RVA = "0xB760B0", Offset = "0xB74EB0", VA = "0x10B760B0")]
    private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance) => new bool();
  }
}
