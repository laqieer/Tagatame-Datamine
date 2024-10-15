// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawListIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002996")]
  [AddComponentMenu("UI/Rune/RuneDrawListIcon")]
  public class RuneDrawListIcon : MonoBehaviour
  {
    [Token(Token = "0x400C8EF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject RuneItemGO;
    [Token(Token = "0x400C8F0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject RuneFrameGO;
    [Token(Token = "0x400C8F1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject EvoImageGO;
    [Token(Token = "0x400C8F2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ImageArray EnhImageArray;
    [Token(Token = "0x400C8F3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject SetTypeGO;
    [Token(Token = "0x400C8F4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image mOwnerIcon;
    [Token(Token = "0x400C8F5")]
    [FieldOffset(Offset = "0x24")]
    private BindRuneData mRuneData;

    [Token(Token = "0x600BC7B")]
    [Address(RVA = "0x8419D0", Offset = "0x8407D0", VA = "0x108419D0")]
    public void SetDrawParam(BindRuneData rundata)
    {
    }

    [Token(Token = "0x600BC7C")]
    [Address(RVA = "0x841680", Offset = "0x840480", VA = "0x10841680")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC7D")]
    [Address(RVA = "0x841540", Offset = "0x840340", VA = "0x10841540")]
    private void RefreshOwnerIcon()
    {
    }

    [Token(Token = "0x600BC7E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneDrawListIcon()
    {
    }
  }
}
