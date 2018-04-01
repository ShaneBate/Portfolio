<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrimeRate.aspx.cs" Inherits="AtlantaCrime.Pages.CrimeRate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container">
        <br />
        <h3>Crime rates for your neighborhood</h3>
        <p>Select your neighborhood</p>
        <asp:DropDownList runat="server" ID="ddlhood" AutoPostBack="True" OnSelectedIndexChanged="ddlhood_SelectedIndexChanged" ViewStateMode="Enabled" EnableViewState="true"></asp:DropDownList>
        <br />
        <br />
        <asp:Literal ID="lblregion" runat="server" />
        <br />
        <div class="col-md">
            <canvas id="myChart"></canvas>
        </div>
        
        <script>
            var ctx = document.getElementById("myChart");
            var myChart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: ["Homicide", "Robbery-Residence", "Robbery-Commercial", "Rape", "Burglary-Nonres", "Robbery-Pedestrain", "Agg Assault", "Burglart-Residence", "Auto Theft", "Larceny-Non Vehicle", "Larceny-From Vehicle"],
                    datasets: [{
                        label: '# of Crimes committed',
                        data: [75, 132, 157, 225, 758, 1126, 2024, 2635, 3197, 6589, 9840],
                        backgroundColor: [
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(255, 99, 132, 0.2)'
                        ],
                        borderColor: [
                            'rgba(255,99,132,1)',
                            'rgba(255,99,132,1)',
                            'rgba(255,99,132,1)',
                            'rgba(255,99,132,1)',
                            'rgba(255,99,132,1)',
                            'rgba(255,99,132,1)',
                            'rgba(255,99,132,1)',
                            'rgba(255,99,132,1)',
                            'rgba(255,99,132,1)',
                            'rgba(255,99,132,1)',
                            'rgba(255,99,132,1)'
                        ],
                        borderWidth: 1
                    }]
                },
                options: {
                    scales: {
                        yAxes: [{
                            ticks: {
                                beginAtZero: true
                            }
                        }]
                    }
                }
            });
        </script>
    </div>
</asp:Content>
