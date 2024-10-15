// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalReplaceTabFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002290")]
  public class CrystalReplaceTabFilter : MonoBehaviour
  {
    [Token(Token = "0x4009982")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private EElement mElement;
    [Token(Token = "0x4009983")]
    [FieldOffset(Offset = "0xD")]
    [SerializeField]
    private bool mIsFavorite;
    [Token(Token = "0x4009984")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle mToggle;

    [Token(Token = "0x170014C9")]
    public EElement GetElement
    {
      [Token(Token = "0x60093F6"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x170014CA")]
    public bool GetIsFavorite
    {
      [Token(Token = "0x60093F7"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170014CB")]
    public Toggle GetToggle
    {
      [Token(Token = "0x60093F8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Toggle) null;
      }
    }

    [Token(Token = "0x60093F9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalReplaceTabFilter()
    {
    }
  }
}
