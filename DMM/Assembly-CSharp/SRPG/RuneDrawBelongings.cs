// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawBelongings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002980")]
  [AddComponentMenu("UI/Rune/RuneDrawBelongings")]
  public class RuneDrawBelongings : MonoBehaviour
  {
    [Token(Token = "0x400C85C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RawImage mItemImg;
    [Token(Token = "0x400C85D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mItemNum;
    [Token(Token = "0x400C85E")]
    [FieldOffset(Offset = "0x14")]
    private ItemData mItemData;

    [Token(Token = "0x600BC0A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BC0B")]
    [Address(RVA = "0x83B5B0", Offset = "0x83A3B0", VA = "0x1083B5B0")]
    public void SetDrawParam(ItemData item_data)
    {
    }

    [Token(Token = "0x600BC0C")]
    [Address(RVA = "0x83B460", Offset = "0x83A260", VA = "0x1083B460")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC0D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneDrawBelongings()
    {
    }
  }
}
