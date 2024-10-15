// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.JSONData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036CD")]
  public class JSONData : JSONNode
  {
    [Token(Token = "0x4010179")]
    [FieldOffset(Offset = "0x8")]
    private string m_Data;

    [Token(Token = "0x170023AE")]
    public override string Value
    {
      [Token(Token = "0x600F835"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0", Slot = "9")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F836"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150", Slot = "10")] set
      {
      }
    }

    [Token(Token = "0x600F837")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public JSONData(string aData)
    {
    }

    [Token(Token = "0x600F838")]
    [Address(RVA = "0xB6E2A0", Offset = "0xB6D0A0", VA = "0x10B6E2A0")]
    public JSONData(float aData)
    {
    }

    [Token(Token = "0x600F839")]
    [Address(RVA = "0xB6E2E0", Offset = "0xB6D0E0", VA = "0x10B6E2E0")]
    public JSONData(double aData)
    {
    }

    [Token(Token = "0x600F83A")]
    [Address(RVA = "0xB6E270", Offset = "0xB6D070", VA = "0x10B6E270")]
    public JSONData(bool aData)
    {
    }

    [Token(Token = "0x600F83B")]
    [Address(RVA = "0xB6E320", Offset = "0xB6D120", VA = "0x10B6E320")]
    public JSONData(int aData)
    {
    }

    [Token(Token = "0x600F83C")]
    [Address(RVA = "0xB6E1D0", Offset = "0xB6CFD0", VA = "0x10B6E1D0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F83D")]
    [Address(RVA = "0xB6E220", Offset = "0xB6D020", VA = "0x10B6E220", Slot = "17")]
    public override string ToString(string aPrefix) => (string) null;

    [Token(Token = "0x600F83E")]
    [Address(RVA = "0xB6DED0", Offset = "0xB6CCD0", VA = "0x10B6DED0", Slot = "28")]
    public override void Serialize(BinaryWriter aWriter)
    {
    }
  }
}
