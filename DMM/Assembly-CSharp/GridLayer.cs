// Decompiled with JetBrains decompiler
// Type: GridLayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000012")]
[AddComponentMenu("Battle/GridLayer")]
[RequireComponent(typeof (MeshRenderer))]
[RequireComponent(typeof (MeshFilter))]
[DisallowMultipleComponent]
public class GridLayer : MonoBehaviour
{
  [Token(Token = "0x4000047")]
  [FieldOffset(Offset = "0xC")]
  public int LayerID;
  [Token(Token = "0x4000048")]
  [FieldOffset(Offset = "0x10")]
  [Multiline]
  public string Preview;
  [Token(Token = "0x4000049")]
  [FieldOffset(Offset = "0x14")]
  private int mXSize;
  [Token(Token = "0x400004A")]
  [FieldOffset(Offset = "0x18")]
  private int mYSize;
  [Token(Token = "0x400004B")]
  [FieldOffset(Offset = "0x1C")]
  private Texture2D mTex;
  [Token(Token = "0x400004C")]
  [FieldOffset(Offset = "0x20")]
  private Color32[] mPixels;
  [Token(Token = "0x400004D")]
  [FieldOffset(Offset = "0x24")]
  private float mOpacity;
  [Token(Token = "0x400004E")]
  [FieldOffset(Offset = "0x28")]
  private float mTransitTime;
  [Token(Token = "0x400004F")]
  [FieldOffset(Offset = "0x2C")]
  private float mDesiredOpacity;
  [Token(Token = "0x4000050")]
  [FieldOffset(Offset = "0x30")]
  private float mCurrentOpacity;

  [Token(Token = "0x6000069")]
  [Address(RVA = "0x2C5CC0", Offset = "0x2C4AC0", VA = "0x102C5CC0")]
  private void Start()
  {
  }

  [Token(Token = "0x600006A")]
  [Address(RVA = "0x2C6000", Offset = "0x2C4E00", VA = "0x102C6000")]
  public void UpdateGrid(GridMap<Color32> grid)
  {
  }

  [Token(Token = "0x600006B")]
  [Address(RVA = "0x2C5620", Offset = "0x2C4420", VA = "0x102C5620")]
  private void Awake()
  {
  }

  [Token(Token = "0x600006C")]
  [Address(RVA = "0x2C6110", Offset = "0x2C4F10", VA = "0x102C6110")]
  private void Update()
  {
  }

  [Token(Token = "0x600006D")]
  [Address(RVA = "0x2C5AD0", Offset = "0x2C48D0", VA = "0x102C5AD0")]
  private void OnWillRenderObject()
  {
  }

  [Token(Token = "0x600006E")]
  [Address(RVA = "0x2C5790", Offset = "0x2C4590", VA = "0x102C5790")]
  private void InitTexture(int w, int h)
  {
  }

  [Token(Token = "0x600006F")]
  [Address(RVA = "0x2C5A30", Offset = "0x2C4830", VA = "0x102C5A30")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000070")]
  [Address(RVA = "0x2C5C70", Offset = "0x2C4A70", VA = "0x102C5C70")]
  public void Show()
  {
  }

  [Token(Token = "0x6000071")]
  [Address(RVA = "0x2C5770", Offset = "0x2C4570", VA = "0x102C5770")]
  public void Hide()
  {
  }

  [Token(Token = "0x6000072")]
  [Address(RVA = "0x2C5B50", Offset = "0x2C4950", VA = "0x102C5B50")]
  public void SetMask(bool enable)
  {
  }

  [Token(Token = "0x6000073")]
  [Address(RVA = "0x2C56A0", Offset = "0x2C44A0", VA = "0x102C56A0")]
  public void ChangeMaterial(string path)
  {
  }

  [Token(Token = "0x6000074")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public GridLayer()
  {
  }
}
