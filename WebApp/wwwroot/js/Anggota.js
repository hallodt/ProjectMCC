$(document).ready(function () {

    $('#TableAnggota').DataTable({
        ajax: {
            url: `https://localhost:7189/api/User/GetAnggota`,
            dataSrc: `data`,
            "headers": {
                'Content-Type': 'application/x-www-form-urlencoded'
            },
            "type": "GET"

        },
        columns: [
            {
                data: null,
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            { data: 'nomorAnggota', },
            { data: 'nama', },
            {
                data: 'tglLahir', /*render: $.fn.dataTable.render.moment( 'M/D/YYYY' )*/
                //"render": function (data, type, row, meta) {

                //    return `<p>${data.format('D-MM-YYYY')}</p>`;
                //}  
            },
            { data: 'pekerjaan', },
            { data: 'tglEntry', },
            {
                data: 'status',
                "render": function (data, type, row, meta) {
                    if (row.status == 'Aktif') {
                        return `
                    <span class='badge badge-success'>Aktif</span>
                    `;
                    } else {
                        return `
                    <span class='badge badge-danger'>Keluar</span>
                    `;
                    }

                }
            },
            {
                data: null,
                "render": function (data, type, row, meta) {

                    if (row.status == 'Aktif') {
                        return `
                    <div class="btn-group align-items-center" role="group">
					<a href="#editModalAnggota" title="Edit Data" class="btn btn-warning btn-sm" data-toggle="modal" data-target="#editModalAnggota"><i class="fa fa-edit"></i></a>
                    <a title="Keluarkan Anggota" onclick="keluarAnggota('${data.idUser}')" class="btn btn-primary btn-sm"><i class="fa fa-sign-out-alt"></i></a>	
					</div>
                    `;
                    } else {
                        return `
                    <span class='badge badge-secondary'>Tidak Tersedia</span>
                    `;
                    }
                }
            }

        ],
        columnDefs: [
            //{
            //    targets: [5],
            //    render: $.fn.dataTable.render.moment('YYYY-MM-DDTHH:mm:ss.SSS', 'YYYY/MM/DD')
            //},

            {
                targets: [3,5],
                render: $.fn.dataTable.render.moment('YYYY-MM-DDTHH:mm:ss', 'YYYY/MM/DD')
            },
            // Center align the header content of column 1
            { className: "dt-head-center", targets: "_all" },
            // Center align the body content of columns 2, 3, & 4
            { className: "dt-body-center", targets: "_all" }
        ]
    });
});

function addAnggota() {
    let data = new Object();
    let id = 0;
    let nomor_anggota = "";
    let nama = $('#nama_anggota').val();
    let email = $('#email_anggota').val();
    let username = $('#username_anggota').val();
    let password = "";
    let alamat = $('#alamat_anggota').val();
    let jk = $('#jenis_kelamin').val();
    let pekerjaan = $('#pekerjaan_anggota').val();
    let tgl_masuk = new Date($('#tgl_masuk').val()).toJSON();
    let idRole = 3;
    let telpon = $('#telpon_anggota').val();
    let lahir = $('#tmp_lahir').val();
    let tgl_lahir = new Date($('#tgl_lahir').val()).toJSON();
    let status = "";
    let u_entry = $('#u_entry').val();
    let tgl_entry = new Date($('#tgl_entry').val()).toJSON();

    data = {
        "idUser": id,
        "nomorAnggota": nomor_anggota,
        "nama": nama,
        "email": email,
        "userName": username,
        "password": password,
        "alamat": alamat,
        "jenisKelamin": jk,
        "pekerjaan": pekerjaan,
        "tglMasuk": tgl_masuk,
        "idRole": idRole,
        "telepon": telpon,
        "tempatLahir": lahir,
        "tglLahir": tgl_lahir,
        "status": status,
        "userEntry": u_entry,
        "tglEntry": tgl_entry
    };
    console.log(data);
    $.ajax({
        url: `https://localhost:7189/api/User`,
        type: 'POST',
        data: JSON.stringify(data),
        dataType: 'json',
        headers: {
            'Content-Type': 'application/json'
        },
        success: function () {
            Swal.fire({
                icon: 'success',
                title: 'Data Berhasil Ditambahkan',
                showConfirmButton: false,
                timer: 1500
            });
            setTimeout(function () {
                location.reload();
            }, 1500);
        }
    });
}

//function editAnggota(idUser) {
//    $.ajax({
//        url: `https://localhost:7068/api/Departement/${idUser}`,
//        type: "GET"
//    }).done((res) => {
//        let temp = "";
//        temp += `
//            <input type="hidden" class="form-control" id="departId" value="${res.data.idUser}" readonly>
//            <input type="hidden" class="form-control" id="departId" value="${res.data.idRole}" readonly>
//            <h5>Nama Departement<h5><input type="text" class="form-control" id="departNama" value="${res.data.nama}">
//            <h5>Division ID<h5><input type="text" class="form-control" id="departDivisionID" value="${res.data.divisionID}">
//                <div class="modal-footer">
//                    <button type="button" class="btn btn-primary" id="editBtn" onclick="saveEditDepartement('${res.data.id}')">Simpan Perubahan</button>
//                    <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
//                </div>
//            `;
//        $("#editData").html(temp);

//    }).fail((err) => {
//        console.log(err);
//    });
//}

function keluarAnggota(id) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, do it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: `https://localhost:7189/api/User/Keluarkan?id=${id}&keluarkan=${true}`,
                type: "PUT",
                contentType: "application/json",
                success: function () {
                    Swal.fire({
                        icon: 'success',
                        title: 'Keluar!',
                        text: 'Anggota berhasil dikeluarkan.',
                        showConfirmButton: false,
                        timer: 1500
                    });
                    setTimeout(function () {
                        location.reload();
                    }, 1500);
                },
                error: function () {
                }
            });
        }
    });
}


