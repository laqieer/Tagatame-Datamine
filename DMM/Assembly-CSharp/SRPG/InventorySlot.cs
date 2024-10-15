// Decompiled with JetBrains decompiler
// Type: SRPG.InventorySlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002652")]
  [AddComponentMenu("UI/InventorySlot")]
  public class InventorySlot : MonoBehaviour
  {
    [Token(Token = "0x400B331")]
    [FieldOffset(Offset = "0x0")]
    public static InventorySlot Active;
    [Token(Token = "0x400B332")]
    [FieldOffset(Offset = "0xC")]
    public Animator StateAnimator;
    [Token(Token = "0x400B333")]
    [FieldOffset(Offset = "0x10")]
    public string AnimatorBoolName;
    [Token(Token = "0x400B334")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Empty;
    [Token(Token = "0x400B335")]
    [FieldOffset(Offset = "0x18")]
    public GameObject NonEmpty;
    [Token(Token = "0x400B336")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject[] HideIfEmpty;
    [Token(Token = "0x400B337")]
    [FieldOffset(Offset = "0x20")]
    public int Index;
    [Token(Token = "0x400B338")]
    [FieldOffset(Offset = "0x24")]
    public SRPG_Button Button;

    [Token(Token = "0x600AB1E")]
    [Address(RVA = "0x6E4BB0", Offset = "0x6E39B0", VA = "0x106E4BB0")]
    public void SetItem(ItemData item)
    {
    }

    [Token(Token = "0x600AB1F")]
    [Address(RVA = "0x6E4B70", Offset = "0x6E3970", VA = "0x106E4B70")]
    public void Select()
    {
    }

    [Token(Token = "0x600AB20")]
    [Address(RVA = "0x6E4CD0", Offset = "0x6E3AD0", VA = "0x106E4CD0")]
    public void Update()
    {
    }

    [Token(Token = "0x600AB21")]
    [Address(RVA = "0x6E4ED0", Offset = "0x6E3CD0", VA = "0x106E4ED0")]
    public InventorySlot()
    {
    }
  }
}
