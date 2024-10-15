// Decompiled with JetBrains decompiler
// Type: SRPG.ListItemUnitBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026DB")]
  public class ListItemUnitBadge : MonoBehaviour
  {
    [Token(Token = "0x400B6AF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mParent;
    [Token(Token = "0x400B6B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image mIcon;

    [Token(Token = "0x17001815")]
    public GameObject GetParent
    {
      [Token(Token = "0x600AE02"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17001816")]
    public Image GetIcon
    {
      [Token(Token = "0x600AE03"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x600AE04")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ListItemUnitBadge()
    {
    }
  }
}
