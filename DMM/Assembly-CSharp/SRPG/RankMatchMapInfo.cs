// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchMapInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200291A")]
  [AddComponentMenu("UI/RankMatchMapInfo")]
  public class RankMatchMapInfo : MonoBehaviour
  {
    [Token(Token = "0x400C5F4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameParameter NameParam;
    [Token(Token = "0x400C5F5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameParameter DescriptionParam;
    [Token(Token = "0x400C5F6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameParameter ThumbnailParam;
    [Token(Token = "0x400C5F7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private LText TimeText;

    [Token(Token = "0x600BA07")]
    [Address(RVA = "0x8106B0", Offset = "0x80F4B0", VA = "0x108106B0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600BA08")]
    [Address(RVA = "0x8106C0", Offset = "0x80F4C0", VA = "0x108106C0")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600BA09")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RankMatchMapInfo()
    {
    }
  }
}
