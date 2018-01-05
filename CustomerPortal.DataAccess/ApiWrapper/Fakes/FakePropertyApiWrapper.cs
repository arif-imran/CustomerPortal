// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FakePropertyApiWrapper.cs" company="">
//   
// </copyright>
// <summary>
//   The fake property api wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.ApiWrapper.Fakes
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// The fake property api wrapper.
    /// </summary>
    public class FakePropertyApiWrapper : FakeAipWrapperBase, IPropertyApiWrapper
    {
        /// <summary>
        /// Gets the account statement.
        /// </summary>
        /// <returns>The account statement.</returns>
        /// <param name="accessToken">Access token.</param>
        /// <param name="leaseId">Lease identifier.</param>
        /// <param name="startDate">Start date.</param>
        /// <param name="endDate">End date.</param>
        /// <param name="pageToGet">Page to get.</param>
        /// <param name="numberItems">Number items.</param>
        public async Task<HttpResponseMessage> GetAccountStatement(string accessToken, Guid leaseId, string startDate, string endDate, int pageToGet, int numberItems)
        {
            var content = "{\"AccountStatementEntries\":[{\"Date\":\"2017-05-18T00:00:00\"," +
                "\"InvoiceNo\":\"201721341233\",\"InvoicePeriod\":\"25/03/2017 - 23/06/2017\",\"Description\":\"Rent\",\"Charges\":2.5,\"Payments\":null,\"Balance\":22.5},{\"Date\":\"2017-02-13T00:00:00\"," +
                "\"InvoiceNo\":\"201723412341\",\"InvoicePeriod\":\"25/12/2016 - 24/03/2017\",\"Description\":\"Rent\",\"Charges\":2.5,\"Payments\":null,\"Balance\":20.0},{\"Date\":\"2016-11-16T00:00:00\"," +
                "\"InvoiceNo\":\"201672134123\",\"InvoicePeriod\":\"29/09/2016 - 24/12/2016\",\"Description\":\"Rent\",\"Charges\":2.5,\"Payments\":null,\"Balance\":17.5},{\"Date\":\"2016-08-15T00:00:00\"," +
                "\"InvoiceNo\":\"201612341233\",\"InvoicePeriod\":\"24/06/2016 - 28/09/2016\",\"Description\":\"Rent\",\"Charges\":2.5,\"Payments\":null,\"Balance\":15.0}]," +
                "\"TotalNumberOfItems\":4}";

            return await this.GetFakeResponse(content);
        }

        public async Task<HttpResponseMessage> GetLeaseInfoByLeaseId(string accessToken, Guid leaseId)
        {
            var content = "{\"LeaseInformation\":{\"TenantId\":\"t0002707\"," +
                "\"TenantName\":\"Paris Ltd.\",\"LeaseStatus\":\"Current\",\"LeaseRent\":10.0,\"LeasePeriod\":\"Annual\"," +
                "\"LeaseStartDate\":\"1931-03-25T00:00:00\",\"LeaseEndDate\":\"2999-12-31T00:00:00\",\"IsDirectDebit\":false," +
                "\"PropertyCode\":\"paris033\",\"PropertyAddress\":\"Main street 10 Windows in Paris\",\"UnitId\":\"SOLEUNIT\"," +
                "\"UnitAddress\":\"Hotel -10, Paris South, France, 1234 343, France\"," +
                "\"UnitAddress1\":\"Hotel 12\",\"UnitAddress2\":\"Main street 10 Windows in Paris\"," +
                "\"BuildingManager\":null,\"Tenure\":\"Leasehold\",\"KeyLeaseDocuments\":[],\"AccountBalance\":52.5}}";

            return await this.GetFakeResponse(content);
        }

        /// <summary>
        /// The my profile.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<HttpResponseMessage> GetLeasesByUserId(string accessToken)
        {
            var content =
                "{\"Leases\":[" +
                  "{\"LeaseId\":\"af32a4fb-ec71-4f94-a2d6-0005a9b6e2f2\",\"LeaseAddress\":\"1 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 1\",\"LeaseAccountNumber\":\"abcd2707\",\"LeasePropertyId\":\"e5d8800d-02e3-4a0b-ac12-ed9ab04900e7\",\"HasMaintenance\":false,\"AccountBalance\":22.5,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"7cfec511-2e03-4560-a142-e647237493e1\",\"LeaseAddress\":\"2 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 2\",\"LeaseAccountNumber\":\"abcd0313\",\"LeasePropertyId\":\"ec955b73-58b5-4156-903f-ba5e311c264c\",\"HasMaintenance\":false,\"AccountBalance\":16375.000000000009,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"4f689a7f-22c4-4cd9-91d8-75f1cd1d2227\",\"LeaseAddress\":\"3 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 3\",\"LeaseAccountNumber\":\"abcd6052\",\"LeasePropertyId\":\"215c70a3-6cf8-4947-8952-2cfb4ba90680\",\"HasMaintenance\":false,\"AccountBalance\":0.0,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"94c23ec6-2845-4ac4-bc0f-a70bd75c3a49\",\"LeaseAddress\":\"4 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 4\",\"LeaseAccountNumber\":\"abcd6485\",\"LeasePropertyId\":\"551f1868-0c82-447b-8c13-bfe47d4f0180\",\"HasMaintenance\":false,\"AccountBalance\":5207.5600000000013,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"2181a8ca-c171-4317-b81e-01db324b3e3b\",\"LeaseAddress\":\"5 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 5\",\"LeaseAccountNumber\":\"abcd8257\",\"LeasePropertyId\":\"4b60ff1c-4f35-4e18-9a86-5897c4d81190\",\"HasMaintenance\":true,\"AccountBalance\":13.520000000004075,\"NumberOfJobs\":1},"
                + "{\"LeaseId\":\"3ead2f2d-f8f4-4edd-a528-000c486da2be\",\"LeaseAddress\":\"6 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 5\",\"LeaseAccountNumber\":\"abcd3022\",\"LeasePropertyId\":\"63cbcb9e-8884-461c-b21f-24f55e5a54e4\",\"HasMaintenance\":false,\"AccountBalance\":8072.0000000000164,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"d9719ef1-a4ab-4306-8480-018a12fac184\",\"LeaseAddress\":\"7 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 6\",\"LeaseAccountNumber\":\"abcd7216\",\"LeasePropertyId\":\"6672a531-8924-4f65-96d7-1007b1744f00\",\"HasMaintenance\":false,\"AccountBalance\":158.47000000000116,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"db3c6138-5014-48fd-ba1f-fe227ce2b7fb\",\"LeaseAddress\":\"9 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 2\",\"LeaseAccountNumber\":\"abcd0595\",\"LeasePropertyId\":\"08a9b9e2-f279-42d6-acdc-7573536bedb8\",\"HasMaintenance\":false,\"AccountBalance\":-5.4569682106375694E-12,\"NumberOfJobs\":7},"
                + "{\"LeaseId\":\"bc1976f7-99d1-419f-8f5e-00832fd0483a\",\"LeaseAddress\":\"10 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 3\",\"LeaseAccountNumber\":\"abcd8953\",\"LeasePropertyId\":\"740b7bb2-8def-4154-8618-c2e0fa423590\",\"HasMaintenance\":true,\"AccountBalance\":0.0,\"NumberOfJobs\":6},"
                + "{\"LeaseId\":\"a3e4afd4-fb75-4734-96f9-be1988d0eed3\",\"LeaseAddress\":\"11 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 8\",\"LeaseAccountNumber\":\"abcd0118\",\"LeasePropertyId\":\"f8b85f8c-62ef-4b11-9152-4631d7c385ff\",\"HasMaintenance\":false,\"AccountBalance\":1.8189894035458565E-12,\"NumberOfJobs\":6},"
                + "{\"LeaseId\":\"be55b268-a5b8-4b65-9aaa-b66ac0a9e344\",\"LeaseAddress\":\"12 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 2\",\"LeaseAccountNumber\":\"abcd2564\",\"LeasePropertyId\":\"cf2e034e-4d0d-4161-bb1f-0c2ead75259e\",\"HasMaintenance\":false,\"AccountBalance\":24600.0,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"5a9ff09f-c5e0-4bf1-865b-00622f1c91a6\",\"LeaseAddress\":\"14 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 5\",\"LeaseAccountNumber\":\"abcd6000\",\"LeasePropertyId\":\"3f68d64a-1810-4083-94fc-1744905a23c1\",\"HasMaintenance\":false,\"AccountBalance\":-2.8421709430404007E-14,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"66ae4c4c-e47b-49cd-b2e6-7decfe871f95\",\"LeaseAddress\":\"15 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 6\",\"LeaseAccountNumber\":\"abcd3899\",\"LeasePropertyId\":\"e4da00c2-02d8-468a-b945-d7ec8fcbb6a1\",\"HasMaintenance\":false,\"AccountBalance\":-9.8676622428683913E-13,\"NumberOfJobs\":8},"
                + "{\"LeaseId\":\"25378042-a5cd-4635-961c-fecb9008afe8\",\"LeaseAddress\":\"16 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 2\",\"LeaseAccountNumber\":\"abcd5431\",\"LeasePropertyId\":\"8b0f2277-fb92-4316-bcb4-b23ffa0b59f7\",\"HasMaintenance\":true,\"AccountBalance\":5.4569682106375694E-12,\"NumberOfJobs\":8},"
                + "{\"LeaseId\":\"112b92d6-dff5-43eb-916f-006128ea56c5\",\"LeaseAddress\":\"17 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 8\",\"LeaseAccountNumber\":\"abcd8747\",\"LeasePropertyId\":\"7e641876-2654-4f49-801f-888fb56326b1\",\"HasMaintenance\":false,\"AccountBalance\":1577.3500000000001,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"3cfb5a31-68b4-41fa-9556-008c86487f6d\",\"LeaseAddress\":\"18 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 90\",\"LeaseAccountNumber\":\"abcd1682\",\"LeasePropertyId\":\"1861ff1f-6fd8-4183-9129-7267ce4ad257\",\"HasMaintenance\":true,\"AccountBalance\":417.48000000000047,\"NumberOfJobs\":7},"
                + "{\"LeaseId\":\"b3b5d47b-f7d0-49c6-bed9-008cd1c32640\",\"LeaseAddress\":\"19 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 23\",\"LeaseAccountNumber\":\"abcd1816\",\"LeasePropertyId\":\"c534bd99-0ab5-431e-bb25-83cb80c3d2bf\",\"HasMaintenance\":false,\"AccountBalance\":-7.560174708487466E-12,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"1559aea2-96de-4caf-b7d4-de836965b6ce\",\"LeaseAddress\":\"20 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 12\",\"LeaseAccountNumber\":\"abcd2993\",\"LeasePropertyId\":\"a3acea08-d7be-418b-8cd9-7c9a253c1b60\",\"HasMaintenance\":false,\"AccountBalance\":0.0,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"3f538abe-1788-4848-adbd-e499047bd5bc\",\"LeaseAddress\":\"21 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 43\",\"LeaseAccountNumber\":\"abcd1218\",\"LeasePropertyId\":\"06abcb2a-c86b-462f-8dc1-419fee3bb7a5\",\"HasMaintenance\":false,\"AccountBalance\":0.0,\"NumberOfJobs\":1},"
                + "{\"LeaseId\":\"19dde3b0-7ab5-49ad-a0a1-6aff889409a5\",\"LeaseAddress\":\"22 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 63\",\"LeaseAccountNumber\":\"abcd0322\",\"LeasePropertyId\":\"d37cc20f-e88d-4c49-9a24-06c15deec8dd\",\"HasMaintenance\":true,\"AccountBalance\":3207.6500000000028,\"NumberOfJobs\":2},"
                + "{\"LeaseId\":\"c5bf6b4c-cad9-47f0-b7c8-0583b0ee280a\",\"LeaseAddress\":\"23 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 23\",\"LeaseAccountNumber\":\"abcd3442\",\"LeasePropertyId\":\"7f3d2ad2-b2b2-4667-b9c4-532e81f09113\",\"HasMaintenance\":false,\"AccountBalance\":-92.279999999996107,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"bab9ea31-43d1-42c7-ad2a-8a8211bea83c\",\"LeaseAddress\":\"24 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 33\",\"LeaseAccountNumber\":\"abcd0484\",\"LeasePropertyId\":\"5fce8622-ba74-4119-9d4d-e56420fc4034\",\"HasMaintenance\":true,\"AccountBalance\":5468.0499999999665,\"NumberOfJobs\":6},"
                + "{\"LeaseId\":\"2e308d54-7ee9-4699-b42e-11c6437cac68\",\"LeaseAddress\":\"25 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 88\",\"LeaseAccountNumber\":\"abcd0120\",\"LeasePropertyId\":\"c4945750-5f83-4cd2-a5f0-7aa77dccb8b7\",\"HasMaintenance\":false,\"AccountBalance\":946.42,\"NumberOfJobs\":0},"
                + "{\"LeaseId\":\"770da630-43a7-49df-8b88-7a1eff001d5e\",\"LeaseAddress\":\"26 Dream way\",\"FullLeaseAddress\":null,\"LeaseUnit\":\"Imagination Unit 78\",\"LeaseAccountNumber\":\"abcd6417\",\"LeasePropertyId\":\"64ed0748-2a73-46d5-9462-dbb1d424c1bf\",\"HasMaintenance\":true,\"AccountBalance\":10952.499999999985,\"NumberOfJobs\":5}]}";

            return await this.GetFakeResponse(content);
        }

        public async Task<HttpResponseMessage> GetOutstandingBalance(string accessToken, Guid leaseId)
        {
            var content = "{\"StatementEntries\":[{\"InvoicePeriod\":\"01/05/2017\",\"InvoiceNo\":\"201706002184\",\"Description\":\"Rent\",\"DueDate\":\"24/06/2017\",\"InvoiceAmount\":2.5,\"PaidAmount\":0.0,\"Balance\":22.5,\"Status\":\"Fully Unpaid\",\"NetDue\":2.5},{\"InvoicePeriod\":\"01/02/2017\",\"InvoiceNo\":\"201706000570\",\"Description\":\"Rent\",\"DueDate\":\"25/03/2017\",\"InvoiceAmount\":2.5,\"PaidAmount\":0.0,\"Balance\":20.0,\"Status\":\"Fully Unpaid\",\"NetDue\":2.5},{\"InvoicePeriod\":\"01/11/2016\",\"InvoiceNo\":\"201606004656\",\"Description\":\"Rent\",\"DueDate\":\"25/12/2016\",\"InvoiceAmount\":2.5,\"PaidAmount\":0.0,\"Balance\":17.5,\"Status\":\"Fully Unpaid\",\"NetDue\":2.5},{\"InvoicePeriod\":\"01/08/2016\",\"InvoiceNo\":\"201606002887\",\"Description\":\"Rent\",\"DueDate\":\"29/09/2016\",\"InvoiceAmount\":2.5,\"PaidAmount\":0.0,\"Balance\":15.0,\"Status\":\"Fully Unpaid\",\"NetDue\":2.5},{\"InvoicePeriod\":\"01/05/2016\",\"InvoiceNo\":\"201606001849\",\"Description\":\"Rent\",\"DueDate\":\"24/06/2016\",\"InvoiceAmount\":2.5,\"PaidAmount\":0.0,\"Balance\":12.5,\"Status\":\"Fully Unpaid\",\"NetDue\":2.5},{\"InvoicePeriod\":\"01/03/2016\",\"InvoiceNo\":\"201606000596\",\"Description\":\"Rent\",\"DueDate\":\"24/03/2016\",\"InvoiceAmount\":2.5,\"PaidAmount\":0.0,\"Balance\":10.0,\"Status\":\"Fully Unpaid\",\"NetDue\":2.5},{\"InvoicePeriod\":\"01/12/2015\",\"InvoiceNo\":\"201506005277\",\"Description\":\"Rent\",\"DueDate\":\"24/12/2015\",\"InvoiceAmount\":2.5,\"PaidAmount\":0.0,\"Balance\":7.5,\"Status\":\"Fully Unpaid\",\"NetDue\":2.5},{\"InvoicePeriod\":\"01/09/2015\",\"InvoiceNo\":\"201506003863\",\"Description\":\"Rent\",\"DueDate\":\"28/09/2015\",\"InvoiceAmount\":2.5,\"PaidAmount\":0.0,\"Balance\":5.0,\"Status\":\"Fully Unpaid\",\"NetDue\":2.5},{\"InvoicePeriod\":\"01/05/2015\",\"InvoiceNo\":\"201506002136\",\"Description\":\"Rent\",\"DueDate\":\"23/06/2015\",\"InvoiceAmount\":2.5,\"PaidAmount\":0.0,\"Balance\":2.5,\"Status\":\"Fully Unpaid\",\"NetDue\":2.5}]}";
              

            return await this.GetFakeResponse(content);
        }
    }
}