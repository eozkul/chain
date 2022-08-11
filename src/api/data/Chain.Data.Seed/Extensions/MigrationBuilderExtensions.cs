namespace Microsoft.EntityFrameworkCore.Migrations;
public static class MigrationBuilderExtensions
{
    public static void Migrate(this MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData("Users",
                                    new string[]
                                    {
                                        "Id", "UserName", "Email", "Department", "Address", "Phone", "Position", "Password","UserType","IsActive"
                                    },
                                    new object[,]
                                    {
                                        {"9BB041D9-B7A0-40E3-B47D-979B3619F76B", "admin", "admin@chain.com", "Satış","İzmir","555-555-55-55","Manager", "a5813ad799f804b5cc8d127f9c7e4e09cf96ce2135b9f77b379881a0ab2d1aec",1,true},
                                    });


        migrationBuilder.InsertData("AppUsers",
                                    new string[]
                                    {
                                        "AppUserId","Email", "UserType", "Password","UserType"
                                    },
                                    new object[,]
                                    {
                                        {"5D0ECA3B-7514-4E50-A5CF-C0CB7290C1CE", "admin@chain.com",1,"a5813ad799f804b5cc8d127f9c7e4e09cf96ce2135b9f77b379881a0ab2d1aec"},
                                    });


        migrationBuilder.InsertData("Categories",
                                    new string[]
                                    {
                                        "Id","CategoryName", "Description"
                                    },
                                    new object[,]
                                    {
                                        {"0E391BC2-F4D1-4D3E-A3BC-B0B52874EA0E", "MarbleCategory","gold marble"},
                                    });


        migrationBuilder.InsertData("Customers",
                                    new string[]
                                    {
                                        "Id","CustomerName", "Email", "Phone","Adress"
                                    },
                                    new object[,]
                                    {
                                        {"105280BE-6DCC-4ACC-BBA9-B6E7C8CFED19", "Stones","stones@mail.com","555-555-55-57","İzmir"},
                                    });


        migrationBuilder.InsertData("Orders",
                                    new string[]
                                    {
                                        "Id","CustomerId", "ProductId", "OrderDate"
                                    },
                                    new object[,]
                                    {
                                        {"6DBF4B6F-7C84-457D-9135-FC49E0FEFC0C", "105280BE-6DCC-4ACC-BBA9-B6E7C8CFED19","49688046-98BC-4557-A2D8-FE4441FE7D1B",DateTime.Now},
                                    });


        migrationBuilder.InsertData("Products",
                                    new string[]
                                    {
                                        "Id","ProductName", "SupplierId","CategoryId","Color","Dimension","Stock"
                                    },
                                    new object[,]
                                    {
                                        {"49688046-98BC-4557-A2D8-FE4441FE7D1B", "Marble","985025A7-E79A-4C9E-955C-C91914DF3965","0E391BC2-F4D1-4D3E-A3BC-B0B52874EA0E",1,1,100},
                                    });


        migrationBuilder.InsertData("Suppliers",
                                    new string[]
                                    {
                                        "Id","SupplierName","Adress", "Phone"
                                    },
                                    new object[,]
                                    {
                                        {"985025A7-E79A-4C9E-955C-C91914DF3965", "Stone Marble","İzmir","555-555-55-56"},
                                    });



    }


}
