// Decompiled with JetBrains decompiler
// Type: SRPG.TacticsSceneSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DC2")]
  [ExecuteInEditMode]
  [AddComponentMenu("Battle/TacticsSceneSettings")]
  public class TacticsSceneSettings : SceneRoot
  {
    [Token(Token = "0x4002800")]
    [FieldOffset(Offset = "0x0")]
    public static bool AutoDeactivateScene;
    [Token(Token = "0x4002801")]
    [FieldOffset(Offset = "0x4")]
    private static List<TacticsSceneSettings> mScenes;
    [Token(Token = "0x4002802")]
    [FieldOffset(Offset = "0xC")]
    [HideInInspector]
    public bool OverrideCameraSettings;
    [Token(Token = "0x4002803")]
    [FieldOffset(Offset = "0x10")]
    [HideInInspector]
    public float CameraYawMin;
    [Token(Token = "0x4002804")]
    [FieldOffset(Offset = "0x14")]
    [HideInInspector]
    public float CameraYawMax;
    [Token(Token = "0x4002805")]
    [FieldOffset(Offset = "0x18")]
    public Texture2D ScreenFilter;
    [Token(Token = "0x4002806")]
    [FieldOffset(Offset = "0x1C")]
    public Texture2D BackgroundImage;
    [Token(Token = "0x4002807")]
    [FieldOffset(Offset = "0x20")]
    private Mesh mGridMesh;
    [Token(Token = "0x4002808")]
    [FieldOffset(Offset = "0x24")]
    private List<GridLayer> mGridLayers;

    [Token(Token = "0x170003CD")]
    public static TacticsSceneSettings[] Scenes
    {
      [Token(Token = "0x600378C"), Address(RVA = "0x10AFA10", Offset = "0x10AE810", VA = "0x110AFA10")] get
      {
        return (TacticsSceneSettings[]) null;
      }
    }

    [Token(Token = "0x170003CE")]
    public static int SceneCount
    {
      [Token(Token = "0x600378D"), Address(RVA = "0x10AF9B0", Offset = "0x10AE7B0", VA = "0x110AF9B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600378E")]
    [Address(RVA = "0x10AF440", Offset = "0x10AE240", VA = "0x110AF440")]
    public static void SetScenesActive(bool active)
    {
    }

    [Token(Token = "0x170003CF")]
    public static TacticsSceneSettings LastScene
    {
      [Token(Token = "0x600378F"), Address(RVA = "0x10AF910", Offset = "0x10AE710", VA = "0x110AF910")] get
      {
        return (TacticsSceneSettings) null;
      }
    }

    [Token(Token = "0x170003D0")]
    public static TacticsSceneSettings Instance
    {
      [Token(Token = "0x6003790"), Address(RVA = "0x10AF870", Offset = "0x10AE670", VA = "0x110AF870")] get
      {
        return (TacticsSceneSettings) null;
      }
    }

    [Token(Token = "0x6003791")]
    [Address(RVA = "0x10AE210", Offset = "0x10AD010", VA = "0x110AE210")]
    public static void PopFirstScene()
    {
    }

    [Token(Token = "0x6003792")]
    [Address(RVA = "0x10AF6E0", Offset = "0x10AE4E0", VA = "0x110AF6E0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003793")]
    [Address(RVA = "0x10ADC10", Offset = "0x10ACA10", VA = "0x110ADC10", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6003794")]
    [Address(RVA = "0x10AE130", Offset = "0x10ACF30", VA = "0x110AE130")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6003795")]
    [Address(RVA = "0x10ADFC0", Offset = "0x10ACDC0", VA = "0x110ADFC0")]
    public IEnumerator GenerateGridMeshAsync(int x, int y) => (IEnumerator) null;

    [Token(Token = "0x6003796")]
    [Address(RVA = "0x10ADD10", Offset = "0x10ACB10", VA = "0x110ADD10")]
    private GridLayer FindGridLayer(int layerID, bool autoCreate, string mat_path = null)
    {
      return (GridLayer) null;
    }

    [Token(Token = "0x6003797")]
    [Address(RVA = "0x10AE030", Offset = "0x10ACE30", VA = "0x110AE030")]
    public void HideGridLayer(int layerID)
    {
    }

    [Token(Token = "0x6003798")]
    [Address(RVA = "0x10AE0B0", Offset = "0x10ACEB0", VA = "0x110AE0B0")]
    public void HideGridLayers()
    {
    }

    [Token(Token = "0x6003799")]
    [Address(RVA = "0x10AF690", Offset = "0x10AE490", VA = "0x110AF690")]
    public void ShowGridLayer(int layerID, GridMap<Color32> grid, bool mask)
    {
    }

    [Token(Token = "0x600379A")]
    [Address(RVA = "0x10AF560", Offset = "0x10AE360", VA = "0x110AF560")]
    public void ShowGridLayer(int layerID, GridMap<bool> grid, Color32 color, bool mask = false)
    {
    }

    [Token(Token = "0x600379B")]
    [Address(RVA = "0x10AF510", Offset = "0x10AE310", VA = "0x110AF510")]
    public void ShowGridLayer(int layerID, GridMap<Color32> grid, string mat_path)
    {
    }

    [Token(Token = "0x600379C")]
    [Address(RVA = "0x10AE2E0", Offset = "0x10AD0E0", VA = "0x110AE2E0")]
    private bool RaycastDeformedMesh(
      Mesh mesh,
      Vector3 start,
      Vector3 direction,
      Matrix4x4 world,
      float cameraZ,
      out float hitDistance,
      out Vector3 hitPos,
      out Vector3 hitPosReal)
    {
      return new bool();
    }

    [Token(Token = "0x600379D")]
    [Address(RVA = "0x10AF0B0", Offset = "0x10ADEB0", VA = "0x110AF0B0")]
    public bool RaycastDeformed(Ray ray, out RaycastHit result) => new bool();

    [Token(Token = "0x600379E")]
    [Address(RVA = "0x10AF7F0", Offset = "0x10AE5F0", VA = "0x110AF7F0")]
    public TacticsSceneSettings()
    {
    }

    [Token(Token = "0x600379F")]
    [Address(RVA = "0x10AF770", Offset = "0x10AE570", VA = "0x110AF770")]
    static TacticsSceneSettings()
    {
    }
  }
}
