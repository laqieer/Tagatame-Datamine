// Decompiled with JetBrains decompiler
// Type: SRPG.AspectRatioScaleFitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002052")]
  [ExecuteInEditMode]
  [AddComponentMenu("UI/AspectRatioScaleFitter")]
  public class AspectRatioScaleFitter : MonoBehaviour
  {
    [Token(Token = "0x4008AF3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Vector2 Padding;
    [Token(Token = "0x4008AF4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private float ScaleForSafeArea;
    [Token(Token = "0x4008AF5")]
    [FieldOffset(Offset = "0x18")]
    private Rect lastSafeArea;
    [Token(Token = "0x4008AF6")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 initScale;
    [Token(Token = "0x4008AF7")]
    [FieldOffset(Offset = "0x34")]
    private float lastSetScale;
    [Token(Token = "0x4008AF8")]
    [FieldOffset(Offset = "0x38")]
    private int lastScreenWidth;
    [Token(Token = "0x4008AF9")]
    [FieldOffset(Offset = "0x3C")]
    private int lastScreenHeight;

    [Token(Token = "0x6008648")]
    [Address(RVA = "0x47A340", Offset = "0x479140", VA = "0x1047A340")]
    private void Start()
    {
    }

    [Token(Token = "0x6008649")]
    [Address(RVA = "0x479F20", Offset = "0x478D20", VA = "0x10479F20")]
    private void OnRectTransformDimensionsChange()
    {
    }

    [Token(Token = "0x600864A")]
    [Address(RVA = "0x479F60", Offset = "0x478D60", VA = "0x10479F60")]
    private void Refresh(Rect safeArea)
    {
    }

    [Token(Token = "0x600864B")]
    [Address(RVA = "0x47A1F0", Offset = "0x478FF0", VA = "0x1047A1F0")]
    private void Rescale()
    {
    }

    [Token(Token = "0x600864C")]
    [Address(RVA = "0x479E10", Offset = "0x478C10", VA = "0x10479E10")]
    private bool ApplySafeAreaScale(Rect area) => new bool();

    [Token(Token = "0x600864D")]
    [Address(RVA = "0x47A3F0", Offset = "0x4791F0", VA = "0x1047A3F0")]
    public AspectRatioScaleFitter()
    {
    }
  }
}
