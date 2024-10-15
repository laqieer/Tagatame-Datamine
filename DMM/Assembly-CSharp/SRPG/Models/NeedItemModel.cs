// Decompiled with JetBrains decompiler
// Type: SRPG.Models.NeedItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200334D")]
  public class NeedItemModel : BaseItemModel
  {
    [Token(Token = "0x400F216")]
    [FieldOffset(Offset = "0x20")]
    private int mNeedCount;
    [Token(Token = "0x400F217")]
    [FieldOffset(Offset = "0x24")]
    private Color mNeedTextColor;
    [Token(Token = "0x400F218")]
    [FieldOffset(Offset = "0x34")]
    private bool mIsDispReplace;
    [Token(Token = "0x400F219")]
    [FieldOffset(Offset = "0x38")]
    private List<string> mSubInames;

    [Token(Token = "0x17001E69")]
    public int NeedCount
    {
      [Token(Token = "0x600E2FB"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E6A")]
    public Color NeedTextColor
    {
      [Token(Token = "0x600E2FC"), Address(RVA = "0xAB37E0", Offset = "0xAB25E0", VA = "0x10AB37E0")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x17001E6B")]
    public bool IsDispReplace
    {
      [Token(Token = "0x600E2FD"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E2FE")]
    [Address(RVA = "0xAB34E0", Offset = "0xAB22E0", VA = "0x10AB34E0")]
    public void Initialize(ItemData _item_data, int _need_count, List<string> _sub_inames = null)
    {
    }

    [Token(Token = "0x600E2FF")]
    [Address(RVA = "0xAB3520", Offset = "0xAB2320", VA = "0x10AB3520")]
    public void Initialize(ItemParam _item_param, int _need_count, List<string> _sub_inames = null)
    {
    }

    [Token(Token = "0x600E300")]
    [Address(RVA = "0xAB3560", Offset = "0xAB2360", VA = "0x10AB3560")]
    private void SetData(int _need_count)
    {
    }

    [Token(Token = "0x600E301")]
    [Address(RVA = "0xAB3760", Offset = "0xAB2560", VA = "0x10AB3760")]
    public void SetNum(int _need_count)
    {
    }

    [Token(Token = "0x600E302")]
    [Address(RVA = "0xAB3770", Offset = "0xAB2570", VA = "0x10AB3770")]
    public NeedItemModel()
    {
    }
  }
}
